using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Yodlee.Models
{
   

    public class CobrandSession
    {
        [JsonProperty("cobsession")]
        public string CoBrandSession { get; set; }
    }
}
