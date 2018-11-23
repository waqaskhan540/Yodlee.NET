using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;

namespace Yodlee.Requests.Cobrand
{
    public class CobrandPublickKeyRequest
    {
        public static HttpRequestMessage Create(string baseUri)
        {
            var uri = new Uri($"{baseUri}{EndPoints.COBRAND_PUBLIC_KEY}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get,
            };

            return request;
        }
    }
}
