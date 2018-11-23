using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models;
using Yodlee.Models.User;

namespace Yodlee.Results.User
{
    public class UserLoginResponse : BaseResponse
    {
       

        [JsonProperty("user")]
        public YodleeUser User { get; set; }

        public static UserLoginResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<UserLoginResponse>(jsonString);
        }

    }
    

}
