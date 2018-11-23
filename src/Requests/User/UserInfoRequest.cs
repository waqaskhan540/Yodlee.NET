using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;

namespace Yodlee.Requests.User
{
    public class UserInfoRequest
    {
        public static HttpRequestMessage Create(string baseUrl)
        {
            var uri = new Uri($"{baseUrl}{EndPoints.USER_INFO}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get
            };
            return request;
        }
    }
}
