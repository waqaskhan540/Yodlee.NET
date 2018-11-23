using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Results;

namespace Yodlee.Context
{
    public class YodleeAuthorizationContext : BaseResponse,IYodleeAuthorizationContext
    {
      
        public string CobrandSession { get;  set ; }
        public string UserSession { get;  set; }

        public static YodleeAuthorizationContext Error(string errorCode, string errorMessage)
        {
            return new YodleeAuthorizationContext
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
        }

        public static YodleeAuthorizationContext Success(string userSession,string cobrandSession)
        {
            return new YodleeAuthorizationContext
            {
                UserSession = userSession,
                CobrandSession = cobrandSession
            };
        }
    }

    public interface IYodleeAuthorizationContext
    {
        string CobrandSession { get; set; }
        string UserSession { get; set; }
    }
}
