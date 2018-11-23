using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Config;

namespace Yodlee.Requests.User
{
    public class UserLoginRequest
    {



        public static HttpRequestMessage Create(string baseUri, string loginName, string password, string locale = "en_US")
        {
            var requestBody = new
            {
                user = new
                {
                    loginName = loginName,
                    password = password,
                    locale = locale
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
            var uri = new Uri($"{baseUri}{EndPoints.USER_LOGIN}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Post,
                Content = content
            };

            return request;
        }
    }
}
