using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yodlee.Config
{
    public class EndPoints
    {

        //COBRAND

        public const string COBRAND_LOGIN = "/cobrand/login";
        public const string COBRAND_PUBLIC_KEY = "/cobrand/publicKey";


        //USER
        public const string USER_LOGIN = "/user/login";
        public const string USER_ACCESS_TOKEN = "/user/accessTokens?appIds=10003600";
        public const string USER_REGISTER = "user/register";
        public const string USER_INFO = "user";
        public const string USER_DELETE = "user/unregister";
        public const string USER_UPDATE = "user";
        public const string USER_PASSWORD_RESET_TOKEN = "user/credentials/token";
        public const string USER_PASSWORD_CHANGE = "user/credentials";

        //ACCOUNTS
        public const string ACCOUNTS = "accounts";

        //TRANSACTIONS
        public const string GET_TRANSACTIONS = "transactions";

        //PROVIDERS
        public const string GET_PROVIDER = "providers";

    }
}
