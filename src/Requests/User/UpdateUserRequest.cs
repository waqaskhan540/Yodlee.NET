using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;
using Yodlee.Models.User;

namespace Yodlee.Requests.User
{
    public class UpdateUserRequest
    {
        public static HttpRequestMessage Create(string baseUri,YodleeUserModel user)
        {
            var uri = new Uri($"{baseUri}{EndPoints.USER_UPDATE}");
            var content = new StringContent(user.ToJson(), Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Content = content,
                Method = HttpMethod.Put
            };

            return request;
        }
    }
}
