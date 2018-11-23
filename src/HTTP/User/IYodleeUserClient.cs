using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;
using Yodlee.Models.User;
using Yodlee.Results;
using Yodlee.Results.User;

namespace Yodlee.HTTP.User
{
    public interface IYodleeUserClient
    {
        
        Task<UserLoginResponse> Login(IYodleeAuthorizationContext context, string username, string password);

        Task<YodleeFastLinkResponse> GetFastLinkToken(IYodleeAuthorizationContext context);

        Task<UserResponse> Register(IYodleeAuthorizationContext context, YodleeUserModel User);
        Task<UserResponse> GetInfo(IYodleeAuthorizationContext context);

        Task<bool> Delete(IYodleeAuthorizationContext context);
        Task<bool> Update(IYodleeAuthorizationContext context, YodleeUserModel User);

        Task<PasswordResetTokenResponse> GetPasswordResetToken(IYodleeAuthorizationContext context, string loginName);

        Task<bool> ChangePassword(IYodleeAuthorizationContext context, ChangePasswordModel model);
    }
}
