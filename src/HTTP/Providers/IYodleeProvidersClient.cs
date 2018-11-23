using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.Results.Providers;

namespace Yodlee.HTTP.Providers
{
    public interface IYodleeProvidersClient
    {
        Task<YodleeProviderInfoResponse> Get(IYodleeAuthorizationContext context, int providerId);
    }
}
