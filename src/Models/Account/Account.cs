using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Account
{
    public class Account
    {
        [JsonProperty("CONTAINER")]
        public string Container { get; set; }
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }
        [JsonProperty("accountStatus")]
        public string AccountStatus { get; set; }
        [JsonProperty("accountType")]
        public string AccountType { get; set; }
        [JsonProperty("aggregationSource")]
        public string AggregationSource { get; set; }
        [JsonProperty("amountDue")]
        public AmountInfo AmountDue { get; set; }
        [JsonProperty("availableCredit")]
        public AmountInfo AvailableCredit { get; set; }
        [JsonProperty("balance")]
        public AmountInfo Balance { get; set; }
        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("dueDate")]
        public DateTime DueDate { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("includeInNetWorth")]
        public bool IncludeInNetWorth { get; set; }
        [JsonProperty("isAsset")]
        public bool IsAsset { get; set; }
        [JsonProperty("isManual")]
        public bool IsManual { get; set; }
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("minimumAmountDue")]
        public AmountInfo MinimumAmountDue { get; set; }
        [JsonProperty("providerAccountId")]
        public int ProviderAccountId { get; set; }
        [JsonProperty("providerId")]
        public int ProviderId { get; set; }
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }
        [JsonProperty("totalCashLimit")]
        public AmountInfo TotalCashLimit { get; set; }
        [JsonProperty("totalCreditLine")]
        public AmountInfo TotalCreditLine { get; set; }
        public string ProviderLogo { get; set; }

    }
}
