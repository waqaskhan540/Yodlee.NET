using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models
{
    public class YodleeUserPreferences
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }

    }
}
