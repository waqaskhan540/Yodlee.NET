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
    public class UserRegisterationRequest
    {
        public static HttpRequestMessage Create(string baseUrl,YodleeUserModel user)
        {
            var content = new StringContent(user.ToJson(), Encoding.UTF8, "application/json");
            var uri = new Uri($"{baseUrl}{EndPoints.USER_REGISTER}");

            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Content = content,
                Method = HttpMethod.Post
            };

            return request;
        }
    }
}
