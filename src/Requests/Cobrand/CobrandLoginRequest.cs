using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Config;

namespace Yodlee.Requests.Cobrand
{
    public class CobrandLoginRequest
    {

       

        public static HttpRequestMessage Create(string baseUri,string cobrandUsername, string cobrandPassword, string locale = "en_US")
        {
            var requestBody = new
            {
                cobrand = new
                {
                    cobrandLogin = cobrandUsername,
                    cobrandPassword = cobrandPassword,
                    locale = locale
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var uri = new Uri($"{baseUri}{EndPoints.COBRAND_LOGIN}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Post,
                Content = content,
            };

            return request;

        }
    }
}
