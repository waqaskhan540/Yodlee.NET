using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Yodlee.Config;
using Yodlee.Context;
using Yodlee.Extensions;
using Yodlee.Models.Transaction;
using Yodlee.Requests.Transactions;

namespace Yodlee.HTTP.Transactions
{
    public class YodleeTransactionsClient : IYodleeTransactionsClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly YodleeConfig _yodleeConfig;

        public YodleeTransactionsClient(IHttpClientFactory httpClientFactory, IOptions<YodleeConfig> yodleeConfig)
        {
            _httpClientFactory = httpClientFactory;
            _yodleeConfig = yodleeConfig.Value;
        }

        public async Task<Transaction> Get(IYodleeAuthorizationContext context, TransactionQueryParams queryParams)
        {
            using (HttpClient httpClient = _httpClientFactory.CreateYodleeClient())
            {

                httpClient.AddYodleeAuthorization(context);

                HttpRequestMessage request = TransactionRequest.Create(_yodleeConfig.YodleeBaseUrl, queryParams);
                HttpResponseMessage response = await httpClient.SendAsync(request);

                return await response.ReadAs<Transaction>();
            }
        }

        [Obsolete("Same requirements can be achieved by calling Get by passing TransactionQueryParams{keyword=searchString}")]
        public async Task<Transaction> Get(IYodleeAuthorizationContext context, DateTime fromDate, DateTime toDate)
        {
            return await Get(context, new TransactionQueryParams
            {
                fromDate = fromDate,
                toDate = toDate
            });
        }


        [Obsolete("Same requirements can be achieved by calling Get by passing TransactionQueryParams{keyword=searchString}")]
        public async Task<Transaction> Get(IYodleeAuthorizationContext context, string searchText)
        {
            return await Get(context, new TransactionQueryParams
            {
                keyword = searchText
            });
        }


    }
}
