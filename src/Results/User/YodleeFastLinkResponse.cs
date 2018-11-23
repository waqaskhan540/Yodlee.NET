using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models;
using Yodlee.Models.FastLink;

namespace Yodlee.Results.User
{
    public class YodleeFastLinkResponse : BaseResponse
    {
       

        [JsonProperty("user")]
        public YodleeFastLinkUser User { get; set; }

        public static YodleeFastLinkResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<YodleeFastLinkResponse>(jsonString);
        }
    }
}
