using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models;

namespace Yodlee.Results.Cobrand
{
    public class CobrandLoginResponse : BaseResponse
    {
        

        [JsonProperty("cobrandId")]
        public int CobrandId { get; set; }

        [JsonProperty("applicationId")]
        public string ApplicationId { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("session")]
        public CobrandSession Session { get; set; }

        public static CobrandLoginResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<CobrandLoginResponse>(jsonString);
        }

    }
}
