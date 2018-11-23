using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Yodlee.Extensions
{
    public static class HttpClientFactoryExtensions
    {
        public static HttpClient CreateYodleeClient(this IHttpClientFactory clientFactory)
        {
            return clientFactory.CreateClient("Yodlee");
        }
    }
}
