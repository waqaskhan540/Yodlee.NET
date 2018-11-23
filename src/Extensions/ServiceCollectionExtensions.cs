using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yodlee.Config;
using Yodlee.HTTP.Accounts;
using Yodlee.HTTP.Cobrand;
using Yodlee.HTTP.User;
using Yodlee.HTTP.Transactions;
using Yodlee.HTTP.Context;
using Yodlee.Unit;
using Yodlee.HTTP.Providers;

namespace Yodlee.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddYodlee(this IServiceCollection services, IConfiguration configuration) {

            string cobrandName = configuration["Yodlee:CobrandName"];
            string apiVersion = configuration["Yodlee:ApiVersion"];

            services.AddHttpClient("Yodlee", client =>
             {                
                 client.Timeout = TimeSpan.FromMinutes(3);
                 client.AddYodleeRequiredHeaders(cobrandName, apiVersion);
             });

            services.AddScoped<IYodleeProvidersClient, YodleeProvidersClient>();
            services.AddScoped<IYodleeAccountsClient, YodleeAccountsClient>();
            services.AddScoped<IYodleeCobrandClient, YodleeCobrandClient>();
            services.AddScoped<IYodleeUserClient, YodleeUserClient>();
            services.AddScoped<IYodleeTransactionsClient, YodleeTransactionsClient>();
            services.AddScoped<IYodleeContextClient, YodleeContextClient>();
            services.AddScoped<IYodleeClients, YodleeClients>();

            services.Configure<YodleeConfig>(options => configuration.GetSection("Yodlee").Bind(options));
        }
    }
}
