using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models.User;

namespace Yodlee.Results.User
{
    public class ChangePasswordResponse : BaseResponse
    {
        [JsonProperty("user")]
        public ChangePasswordModel User { get; set; }

        public static ChangePasswordResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<ChangePasswordResponse>(jsonString);
        }
    }
}
