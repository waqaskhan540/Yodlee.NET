using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models.Account;

namespace Yodlee.Results.Accounts
{
    public class AccountDetailResponse : BaseResponse
    {

        [JsonProperty("account")]
        public AccountDetail Account { get; set; }

        public static AccountDetailResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<AccountDetailResponse>(jsonString);
        }
    }
}
