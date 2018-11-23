using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.User
{
    public class YodleeUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("loginName")]
        public string LoginName { get; set; }

        [JsonProperty("name")]
        public YodleeUserName Name { get; set; }

        [JsonProperty("roleType")]
        public string RoleType { get; set; }

        [JsonProperty("session")]
        public UserLoginSession Session { get; set; }


    }
}
