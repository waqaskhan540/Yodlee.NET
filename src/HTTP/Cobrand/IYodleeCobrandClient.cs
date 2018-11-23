using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.Results;
using Yodlee.Results.Cobrand;

namespace Yodlee.HTTP.Cobrand
{
    public interface IYodleeCobrandClient
    {
        Task<CobrandLoginResponse> CobrandLogin();
        Task<CobrandPublicKeyResponse> GetCobrandPublicKey(IYodleeAuthorizationContext context);
    }
}
