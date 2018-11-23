using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Results;

namespace Yodlee.Models.User
{
    public class PasswordResetToken : BaseResponse
    {
        [JsonProperty("validUntil")]
        public DateTime ValidUntil { get; set; }
        [JsonProperty("loginName")]
        public string LoginName { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
