using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Models.User;

namespace Yodlee.Results.User
{
    public class PasswordResetTokenResponse:PasswordResetToken
    {
  
        public static PasswordResetTokenResponse FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<PasswordResetTokenResponse>(jsonString);
        }
    }
}
