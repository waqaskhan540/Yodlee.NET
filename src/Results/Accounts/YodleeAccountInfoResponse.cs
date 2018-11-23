using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models;
using Yodlee.Models.Account;

namespace Yodlee.Results.Accounts
{
    public class YodleeAccountInfoResponse : BaseResponse
    {
        [JsonProperty("account")]
        public List<Account> Account { get; set; }

        public static YodleeAccountInfoResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<YodleeAccountInfoResponse>(jsonString);
        }
    }
}
