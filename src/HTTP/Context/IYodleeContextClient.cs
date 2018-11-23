using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;

namespace Yodlee.HTTP.Context
{
    public interface IYodleeContextClient
    {
        Task<YodleeAuthorizationContext> GetYodleeAuthorizationContext(string username,string password);
    }
}
