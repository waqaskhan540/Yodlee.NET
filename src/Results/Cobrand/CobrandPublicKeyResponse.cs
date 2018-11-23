using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Results.Cobrand
{
    public class CobrandPublicKeyResponse : BaseResponse
    {
        [JsonProperty("keyAlias")]
        public string KeyAlias { get; set; }

        [JsonProperty("keyAsPemString")]
        public string PublicKey { get; set; }

        public static CobrandPublicKeyResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<CobrandPublicKeyResponse>(jsonString);
        }
    }
}
