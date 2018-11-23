using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Yodlee.Results;

namespace Yodlee.Models.Transaction
{
    public class Transaction : BaseResponse
    {
        [JsonProperty("transaction")]
        public TransactionElement[] TransactionTransaction { get; set; }

        public static Transaction FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<Transaction>(jsonString);
        }
    }
}
