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
    public class FastLinkRequest
    {

        public static HttpRequestMessage Create(string baseUri)
        {
            var uri = new Uri($"{baseUri}{EndPoints.USER_ACCESS_TOKEN}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get,                
            };
            return request;
        }
    }
}
