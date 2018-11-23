using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models.User;

namespace Yodlee.Results.User
{
    public class UserResponse : BaseResponse
    {
      
        [JsonProperty("user")]
        public YodleeUserModel User { get; set; }

        public static UserResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<UserResponse>(jsonString);
        }
    }
}
