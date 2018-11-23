using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;
using Yodlee.Context;
using Yodlee.Extensions;
using Yodlee.Requests.Providers;
using Yodlee.Results.Providers;

namespace Yodlee.HTTP.Providers
{
    public class YodleeProvidersClient : IYodleeProvidersClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly YodleeConfig _yodleeConfig;

        public YodleeProvidersClient(
            IHttpClientFactory httpClientFactory,
            IOptions<YodleeConfig> yodleeConfig
            )
        {
            _httpClientFactory = httpClientFactory;
            _yodleeConfig = yodleeConfig.Value;
        }
        public async Task<YodleeProviderInfoResponse> Get(IYodleeAuthorizationContext context, int providerId)
        {
            using (var _httpClient = _httpClientFactory.CreateYodleeClient())
            {
                _httpClient.AddYodleeRequiredHeaders(_yodleeConfig.CobrandName, _yodleeConfig.ApiVersion);
                _httpClient.AddYodleeAuthorization(context);

                var request = ProviderInfoRequest.Create(_yodleeConfig.YodleeBaseUrl, providerId);
                var response = await _httpClient.SendAsync(request);

                return await response.ReadAs<YodleeProviderInfoResponse>();

            }
        }
    }
}
