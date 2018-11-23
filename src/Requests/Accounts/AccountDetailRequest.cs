using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Config;
using Yodlee.Models.Account;

namespace Yodlee.Requests.Accounts
{
    public class AccountDetailRequest
    {
        public static HttpRequestMessage Create(string baseUri,int accountId,string container,string include = "")
        {
            var uri = new Uri($"{baseUri}{EndPoints.ACCOUNTS}?accountId={accountId}&container={container}&include={include}");
            var request = new HttpRequestMessage
            {
                RequestUri = uri,
                Method = HttpMethod.Get
            };
            return request;
        }
    }
}
