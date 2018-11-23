using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models.User
{
    public class UserLoginSession
    {
        [JsonProperty("userSession")]
        public string UserSession { get; set; }
    }
}
