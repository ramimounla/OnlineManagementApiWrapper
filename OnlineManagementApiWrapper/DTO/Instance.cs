// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OnlineManagementApiWrapper.DTO;
//
//    var data = Instance.FromJson(jsonString);
using Newtonsoft.Json;

namespace OnlineManagementApiWrapper.DTO
{
    public partial class Instance
    {
        [JsonProperty("InitialUserEmail")]
        public string InitialUserEmail { get; set; }

        [JsonProperty("BaseLanguage")]
        public long BaseLanguage { get; set; }

        [JsonProperty("ApiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("AdminMode")]
        public bool AdminMode { get; set; }

        [JsonProperty("ApplicationUrl")]
        public string ApplicationUrl { get; set; }

        [JsonProperty("FriendlyName")]
        public string FriendlyName { get; set; }

        [JsonProperty("DomainName")]
        public string DomainName { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("StateIsSupportedForDelete")]
        public bool StateIsSupportedForDelete { get; set; }

        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId { get; set; }

        [JsonProperty("Purpose")]
        public string Purpose { get; set; }

        [JsonProperty("State")]
        public long State { get; set; }

        [JsonProperty("UniqueName")]
        public string UniqueName { get; set; }

        [JsonProperty("Type")]
        public long Type { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }
    }

    public partial class Instance
    {
        public static Instance FromJson(string json) => JsonConvert.DeserializeObject<Instance>(json, Converter.Settings);
    }
}
