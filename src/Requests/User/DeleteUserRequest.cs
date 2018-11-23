using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;

namespace Yodlee.Requests.User
{
    public class DeleteUserRequest
    {
        public static HttpRequestMessage Create(string baseUri)
        {
            var uri = new Uri($"{baseUri}{EndPoints.USER_DELETE}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Delete
            };
            return request;
        }
    }
}
