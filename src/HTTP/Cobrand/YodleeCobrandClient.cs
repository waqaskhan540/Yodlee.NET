using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Yodlee.Config;
using Yodlee.Results;
using Yodlee.Extensions;
using Yodlee.Requests;
using Yodlee.Results.Cobrand;
using Yodlee.Requests.Cobrand;
using Yodlee.Context;

namespace Yodlee.HTTP.Cobrand
{
    public class YodleeCobrandClient : IYodleeCobrandClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly YodleeConfig _yodleeConfig;

        public YodleeCobrandClient(IHttpClientFactory httpClientFactory,
            IOptions<YodleeConfig> yodleeConfig)         
        {
            _httpClientFactory = httpClientFactory;         
            _yodleeConfig = yodleeConfig.Value;
        }
        public async Task<CobrandLoginResponse> CobrandLogin()
        {
            using(var _httpClient = _httpClientFactory.CreateYodleeClient())
            {
               
                var request = CobrandLoginRequest.Create(_yodleeConfig.YodleeBaseUrl, _yodleeConfig.CobrandUsername, _yodleeConfig.CobrandPassword);
                var response = await _httpClient.SendAsync(request);

                return await response.ReadAs<CobrandLoginResponse>();
            }
            
        }

        public async Task<CobrandPublicKeyResponse> GetCobrandPublicKey(IYodleeAuthorizationContext context)
        {
            using(var _httpClient = _httpClientFactory.CreateYodleeClient())
            {               
                _httpClient.AddYodleeAuthorization(context);

                var request = CobrandPublickKeyRequest.Create(_yodleeConfig.YodleeBaseUrl);
                var response = await _httpClient.SendAsync(request);

                return await response.ReadAs<CobrandPublicKeyResponse>();

            }
        }
    }
}
