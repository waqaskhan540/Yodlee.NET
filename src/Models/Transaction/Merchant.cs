using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Transaction
{
    public  class Merchant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categoryLabel")]
        public string[] CategoryLabel { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
