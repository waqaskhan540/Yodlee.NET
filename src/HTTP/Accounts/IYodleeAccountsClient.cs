using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.Models.Account;
using Yodlee.Results;
using Yodlee.Results.Accounts;

namespace Yodlee.HTTP.Accounts
{
    public interface IYodleeAccountsClient
    {
        Task<YodleeAccountInfoResponse> Get(IYodleeAuthorizationContext context, AccountQueryParams queryParams);
        Task<AccountDetailResponse> Get(IYodleeAuthorizationContext context, int accountId, string container, string include);
    }
}
