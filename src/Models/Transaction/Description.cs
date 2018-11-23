using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.Transaction
{
    public  class Description
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("consumer")]
        public string Consumer { get; set; }

        [JsonProperty("simple")]
        public string Simple { get; set; }
    }
}
