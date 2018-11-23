using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Yodlee.Models.Provider;

namespace Yodlee.Results.Providers
{
    public class YodleeProviderInfoResponse : BaseResponse
    {
        [JsonProperty("provider")]
        public List<Provider> Provider { get; set; }

        public static YodleeProviderInfoResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<YodleeProviderInfoResponse>(jsonString);
        }
    }
}
