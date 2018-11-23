using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.User
{
    public class ChangePasswordModel
    {
        [JsonProperty("loginName")]
        public string LoginName { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
