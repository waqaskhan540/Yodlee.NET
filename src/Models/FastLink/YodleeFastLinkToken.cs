using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.FastLink
{
    public class YodleeFastLinkToken
    {
        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
