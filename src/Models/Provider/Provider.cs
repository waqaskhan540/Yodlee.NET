using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yodlee.Models.Provider
{
    public class Provider
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }
        [JsonProperty("favicon")]
        public string Favicon { get; set; }
        [JsonProperty("logo")]
        public string Logo { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("isAutoRefreshEnabled")]
        public bool IsAutoRefreshEnabled { get; set; }
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }
        [JsonProperty("languageISOCode")]
        public string LanguageISOCode { get; set; }
        [JsonProperty("primaryLanguageISOCode")]
        public string PrimaryLanguageISOCode { get; set; }
        [JsonProperty("authType")]
        public string AuthType { get; set; }
    }
}
