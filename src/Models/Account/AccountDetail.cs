using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Account
{
    public class AccountDetail:Account
    {
        [JsonProperty("availableBalance")]
        public AmountInfo AvailableBalance { get; set; }

        [JsonProperty("currentBalance")]
        public AmountInfo CurrentBalance { get; set; }

        [JsonProperty("dataset")]
        public DataSet DataSet { get; set; }
    }

    public class DataSet
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("additionalStatus")]
        public string AdditionalStatus { get; set; }
        [JsonProperty("updateEligibility")]
        public string UpdateEligibility { get; set; }
        [JsonProperty("lastUpdateAttempt")]
        public DateTime LastUpdateAttempt { get; set; }
    }
}
