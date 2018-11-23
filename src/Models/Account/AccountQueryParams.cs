using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Account
{
    public class AccountQueryParams
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("container")]
        public string Container { get; set; }
        [JsonProperty("providerAccountId")]
        public string ProviderAccountId { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("accountReconType")]
        public string AccountReconType { get; set; }

        [JsonProperty("include")]
        public string Include { get; set; }

        public string ToQueryString()
        {
            var queryString = string.Empty;
            foreach (var property in GetType().GetProperties())
            {
                var value = property.GetValue(this, null);
                if (value != null)
                {                  
                    queryString += property.Name.First().ToString().ToLower() + property.Name.Substring(1)+ "=" + value.ToString() + "&";
                }
            }

            return queryString.TrimEnd('&');
        }
    }

    public enum Status
    {
        ACTIVE,
        INACTIVE,
        TO_BE_CLOSED,
        CLOSED
    }

    public enum Container
    {
        bank,
        creditCard,
        investment,
        insurance,
        loan,
        reward,
        bill,
        realEstate
    }

    
}
