using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Transaction
{
    public class TransactionElement
    {
        [JsonProperty("CONTAINER")]
        public string Container { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("amount")]
        public AmountInfo Amount { get; set; }

        [JsonProperty("runningBalance")]
        public AmountInfo RunningBalance { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("categoryType")]
        public string CategoryType { get; set; }

        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categorySource")]
        public string CategorySource { get; set; }

        [JsonProperty("highLevelCategoryId")]
        public long HighLevelCategoryId { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("transactionDate")]
        public DateTimeOffset TransactionDate { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("postDate")]
        public DateTimeOffset PostDate { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("isManual")]
        public bool IsManual { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("merchant")]
        public Merchant Merchant { get; set; }
    }
}
