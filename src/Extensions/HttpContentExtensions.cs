using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Results;

namespace Yodlee.Extensions
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAs<T>(this HttpResponseMessage response) where T: BaseResponse,new()
        {
            var stringContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(stringContent);
            }

            return new T
            {
                ErrorCode = response.StatusCode.ToString(),
                ErrorMessage = response.ReasonPhrase
            };

        }
    }
}
