using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yodlee.Config
{
    public class YodleeConfig
    {
        public string YodleeBaseUrl { get; set; }
        public string CobrandName { get; set; }
        public string ApiVersion { get; set; }
        public string CobrandUsername { get; set; }
        public string CobrandPassword { get; set; }

        public bool IsTesting { get; set; }
        public string TestUsername { get; set; }
        public string TestPassword { get; set; }

        public string TestAccounts { get; set; }
        public string Locale { get; set; } = "en_US"; //Need to change it

        public string Currency { get; set; } = "GBP";
        public string TimeZone { get; set; } = "BST";
        public string DateFormat { get; set; } = "MM/dd/yyyy";
    }
}
