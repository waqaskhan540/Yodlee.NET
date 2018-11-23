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
    public interface IYodleeClients
    {
        IYodleeProvidersClient Providers { get; }
        IYodleeTransactionsClient Transactions { get; }
        IYodleeAccountsClient Accounts { get; }
        IYodleeUserClient User { get; }
        
        IYodleeCobrandClient Cobrand { get;  }
        IYodleeContextClient Context { get;  }

    }
}
