using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.FastLink
{
    public class YodleeFastLinkUser
    {
        [JsonProperty("accessTokens")]
        public List<YodleeFastLinkToken> AccessTokens { get; set; }
    }
}
