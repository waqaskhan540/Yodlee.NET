using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Config;
using Yodlee.Models.Account;

namespace Yodlee.Requests.Accounts
{
    public class AccountInfoRequest
    {



        public static HttpRequestMessage Create(string baseUri,AccountQueryParams queryParams)
        {
            var uri = new Uri($"{baseUri}{EndPoints.ACCOUNTS}?{queryParams.ToQueryString()}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get,
            };

            return request;
        }
    }
}
