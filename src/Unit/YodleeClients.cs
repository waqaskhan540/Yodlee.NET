using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.HTTP.Accounts;
using Yodlee.HTTP.Cobrand;
using Yodlee.HTTP.Context;
using Yodlee.HTTP.Providers;
using Yodlee.HTTP.Transactions;
using Yodlee.HTTP.User;

namespace Yodlee.Unit
{
    public class YodleeClients : IYodleeClients

    {
        public IYodleeProvidersClient Providers { get; private set; }
        public IYodleeTransactionsClient Transactions { get; private set; }
       public IYodleeAccountsClient Accounts { get; private set; }
        public IYodleeUserClient User { get; private set; }
        public IYodleeCobrandClient Cobrand { get; private set; }
        public IYodleeContextClient Context { get; private set; }

        public YodleeClients(
            IYodleeProvidersClient providers,
            IYodleeTransactionsClient transactions,
            IYodleeAccountsClient accounts,
            IYodleeUserClient users,
            IYodleeCobrandClient cobrand,
            IYodleeContextClient context)
        {
            this.Providers = providers;
            this.Transactions = transactions;
            this.Accounts = accounts;
            this.User = users;
            this.Cobrand = cobrand;
            this.Context = context;
        }
    }
}
