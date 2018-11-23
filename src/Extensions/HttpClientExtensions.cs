using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Yodlee.Context;

namespace Yodlee.Extensions
{
    public static class HttpClientExtensions
    {
        public static void AddYodleeRequiredHeaders(this HttpClient httpClient,string cobrandName,string apiVersion)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Cobrand-Name", cobrandName);
            httpClient.DefaultRequestHeaders.Add("Api-Version", apiVersion);
        }

        public static void AddYodleeAuthorization(this HttpClient httpClient,IYodleeAuthorizationContext authContext)
        {

            string authHeader = string.Empty; 
            if(authContext.UserSession != null)
            {
                 authHeader = "{cobSession=" + authContext.CobrandSession + ",userSession=" + authContext.UserSession + "}";
            }else
            {
                authHeader = "{cobSession=" + authContext.CobrandSession + "}";
            }
                       
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authHeader);
        }
    }
}
