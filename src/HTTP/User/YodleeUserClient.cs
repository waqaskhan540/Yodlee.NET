using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Yodlee.Config;
using Yodlee.Results;
using Yodlee.Extensions;
using Yodlee.Requests;
using Yodlee.Results.User;
using Yodlee.Requests.User;
using Yodlee.Models.User;
using Yodlee.Context;

namespace Yodlee.HTTP.User
{
    public class YodleeUserClient : IYodleeUserClient
    {

        private readonly IHttpClientFactory _httpClientFactory;      
        private readonly YodleeConfig _yodleeConfig;

        public YodleeUserClient(
            IHttpClientFactory httpClientFactory,
            IOptions<YodleeConfig> yodleeConfig
          )
        {
            _httpClientFactory = httpClientFactory;         
            _yodleeConfig = yodleeConfig.Value;
        }
        public async Task<UserLoginResponse> Login(IYodleeAuthorizationContext yodleeAuthorizationContext, string username, string password)
        {

            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = UserLoginRequest.Create(_yodleeConfig.YodleeBaseUrl, username, password);
                var response = await httpClient.SendAsync(request);

                return await response.ReadAs<UserLoginResponse>();              
            }

        }

        public async Task<YodleeFastLinkResponse> GetFastLinkToken(IYodleeAuthorizationContext yodleeAuthorizationContext)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = FastLinkRequest.Create(_yodleeConfig.YodleeBaseUrl);
                var response = await httpClient.SendAsync(request);

                return await response.ReadAs<YodleeFastLinkResponse>();               
            }
        }

        public async Task<UserResponse> Register(IYodleeAuthorizationContext yodleeAuthorizationContext, YodleeUserModel User)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = UserRegisterationRequest.Create(_yodleeConfig.YodleeBaseUrl, User);
                var response = await httpClient.SendAsync(request);

                return await response.ReadAs<UserResponse>();                
            }
        }

        public async Task<UserResponse> GetInfo(IYodleeAuthorizationContext yodleeAuthorizationContext)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = UserInfoRequest.Create(_yodleeConfig.YodleeBaseUrl);
                var response = await httpClient.SendAsync(request);
                return await response.ReadAs<UserResponse>();                
            }
        }

        public async Task<bool> Delete(IYodleeAuthorizationContext yodleeAuthorizationContext)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = DeleteUserRequest.Create(_yodleeConfig.YodleeBaseUrl);
                var response = await httpClient.SendAsync(request);
                
                 return response.IsSuccessStatusCode;
            }
        }

        public async Task<bool> Update(IYodleeAuthorizationContext yodleeAuthorizationContext, YodleeUserModel User)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = UpdateUserRequest.Create(_yodleeConfig.YodleeBaseUrl, User);
                var response = await httpClient.SendAsync(request);

                return response.IsSuccessStatusCode;
            }
        }

        public async Task<PasswordResetTokenResponse> GetPasswordResetToken(IYodleeAuthorizationContext yodleeAuthorizationContext, string loginName)
        {
            using (var httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = PasswordResetTokenRequest.Create(_yodleeConfig.YodleeBaseUrl);
                var response = await httpClient.SendAsync(request);

                return await response.ReadAs<PasswordResetTokenResponse>();                
            }
        }

        public async Task<bool> ChangePassword(IYodleeAuthorizationContext yodleeAuthorizationContext, ChangePasswordModel model)
        {
            using (var _httpClient = _httpClientFactory.CreateYodleeClient())
            {
                
                _httpClient.AddYodleeAuthorization(yodleeAuthorizationContext);

                var request = ChangePasswordRequest.Create(_yodleeConfig.YodleeBaseUrl, model);
                var response = await _httpClient.SendAsync(request);

                return response.IsSuccessStatusCode;
            }
        }
    }
}
