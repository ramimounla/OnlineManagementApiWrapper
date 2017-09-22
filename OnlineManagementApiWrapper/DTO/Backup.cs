// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OnlineManagementApiWrapper.DTO;
//
//    var data = Backup.FromJson(jsonString);
using Newtonsoft.Json;

namespace OnlineManagementApiWrapper.DTO
{
    public partial class Backup
    {
        [JsonProperty("ExpiresOn")]
        public string ExpiresOn { get; set; }

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("AzureStorageInformation")]
        public AzureStorageInformation AzureStorageInformation { get; set; }

        [JsonProperty("CreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("IsAzureBackup")]
        public bool IsAzureBackup { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }
    }

    public partial class Backup
    {
        public static Backup FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Backup>(json, Converter.Settings);
        }
    }

}
