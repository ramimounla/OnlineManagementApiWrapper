// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OnlineManagementApiWrapper.DTO;
//
//    var data = BackupRequest.FromJson(jsonString);
//
using Newtonsoft.Json;

namespace OnlineManagementApiWrapper.DTO
{
    public partial class BackupRequest
    {
        [JsonProperty("InstanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("Label")]
        public string Label { get; set; }

        [JsonProperty("AzureStorageInformation")]
        public AzureStorageInformation AzureStorageInformation { get; set; }

        [JsonProperty("IsAzureBackup")]
        public string IsAzureBackup { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }
    }

    public partial class BackupRequest
    {
        public static BackupRequest FromJson(string json) => JsonConvert.DeserializeObject<BackupRequest>(json, Converter.Settings);
    }
}
