using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Yodlee.Config;
using Yodlee.Results;
using Yodlee.Extensions;
using Yodlee.Requests;
using Yodlee.Results.Accounts;
using Yodlee.Requests.Accounts;
using Yodlee.Models.Account;
using Yodlee.Context;

namespace Yodlee.HTTP.Accounts
{
    public class YodleeAccountsClient : IYodleeAccountsClient
    {

        private readonly IHttpClientFactory _httpClientFactory;       
        private readonly YodleeConfig _yodleeConfig;

        public YodleeAccountsClient(
            IHttpClientFactory httpClientFactory, 
            IOptions<YodleeConfig> yodleeConfig                  
            )
        {
            _httpClientFactory = httpClientFactory;
            _yodleeConfig = yodleeConfig.Value;
        }

      

        public async Task<YodleeAccountInfoResponse> Get(IYodleeAuthorizationContext context, AccountQueryParams queryParams)
        {
            using (var _httpClient = _httpClientFactory.CreateYodleeClient())
            {
                _httpClient.AddYodleeRequiredHeaders(_yodleeConfig.CobrandName, _yodleeConfig.ApiVersion);
                _httpClient.AddYodleeAuthorization(context);

                var request = AccountInfoRequest.Create(_yodleeConfig.YodleeBaseUrl,queryParams);
                var response = await _httpClient.SendAsync(request);

                return await response.ReadAs<YodleeAccountInfoResponse>();               

            }
        }

        public async Task<AccountDetailResponse> Get(IYodleeAuthorizationContext context, int accountId, string container, string include = "")
        {
            using (var _httpClient = _httpClientFactory.CreateYodleeClient())
            {
               
                _httpClient.AddYodleeAuthorization(context);

                var request = AccountDetailRequest.Create(_yodleeConfig.YodleeBaseUrl,accountId,container,include);
                var response = await _httpClient.SendAsync(request);

                return await response.ReadAs<AccountDetailResponse>();
            }
        }
    }
}
