using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Yodlee.Config;

namespace Yodlee.Requests.Providers
{
    public class ProviderInfoRequest
    {
        public static HttpRequestMessage Create(string baseUri, int providerId)
        {
            var uri = new Uri($"{baseUri}{EndPoints.GET_PROVIDER}/{providerId}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get,
            };

            return request;
        }
    }
}
