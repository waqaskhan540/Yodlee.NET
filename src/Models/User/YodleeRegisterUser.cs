using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models.Transaction;

namespace Yodlee.Models.User
{
    public class YodleeUserModel
    {
        
        [JsonProperty("loginName")]
        public string LoginName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public YodleeUserName Name { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("preferences")]
        public YodleeUserPreferences Preferences { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
