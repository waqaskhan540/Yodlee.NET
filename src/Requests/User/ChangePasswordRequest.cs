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
    public class ChangePasswordRequest
    {
        public static HttpRequestMessage Create(string baseUrl,ChangePasswordModel changePasswordModel)
        {
            var uri = new Uri($"{baseUrl}{EndPoints.USER_PASSWORD_CHANGE}");
            var content = new StringContent(changePasswordModel.ToJson(), Encoding.UTF8, "application/json");
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
