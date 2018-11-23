using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;
using Yodlee.Models.Transaction;

namespace Yodlee.Requests.Transactions
{
    public class TransactionRequest
    {
        public static HttpRequestMessage Create(string baseUri,TransactionQueryParams queryParams)
        {            
            var uri = new Uri($"{baseUri}{EndPoints.GET_TRANSACTIONS}?{queryParams.ToQueryString()}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get,                
            };

            return request;

        }
    }
}
