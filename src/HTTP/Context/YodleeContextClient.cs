using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.HTTP.Cobrand;
using Yodlee.HTTP.User;

namespace Yodlee.HTTP.Context
{
    public class YodleeContextClient : IYodleeContextClient
    {
        private readonly IYodleeCobrandClient _cobrandClient;
        private readonly IYodleeUserClient _userClient;

        public YodleeContextClient(IYodleeCobrandClient cobrandClient,IYodleeUserClient userClient)
        {
            _cobrandClient = cobrandClient;
            _userClient = userClient;
        }
        public async Task<YodleeAuthorizationContext> GetYodleeAuthorizationContext(string username,string password)
        {
            string cobrandSession = "";
            string userSession = "";

            var cobrandSessionResponse = await _cobrandClient.CobrandLogin();
            if(cobrandSessionResponse.ErrorCode != null)
                return YodleeAuthorizationContext.Error(cobrandSessionResponse.ErrorCode, cobrandSessionResponse.ErrorMessage);
            
            cobrandSession = cobrandSessionResponse.Session.CoBrandSession;
            var authContext = new YodleeAuthorizationContext { CobrandSession = cobrandSession };

            var userSessionResponse = await _userClient.Login(authContext, username, password);
            if(userSessionResponse.ErrorCode != null)
                return YodleeAuthorizationContext.Error(userSessionResponse.ErrorCode, userSessionResponse.ErrorMessage);
            
            userSession = userSessionResponse.User.Session.UserSession;
            return YodleeAuthorizationContext.Success(userSession, cobrandSession);
        }
    }
}
