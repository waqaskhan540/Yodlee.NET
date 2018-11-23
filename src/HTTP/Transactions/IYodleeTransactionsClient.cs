using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.Models.Transaction;

namespace Yodlee.HTTP.Transactions
{
    public interface IYodleeTransactionsClient
    {
        Task<Transaction> Get(IYodleeAuthorizationContext context, TransactionQueryParams queryParams);
        Task<Transaction> Get(IYodleeAuthorizationContext context, string filterQuery);
        Task<Transaction> Get(IYodleeAuthorizationContext context, DateTime fromData, DateTime toDate);
    }
}
