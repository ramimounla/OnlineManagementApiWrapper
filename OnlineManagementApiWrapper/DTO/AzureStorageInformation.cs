// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using OnlineManagementApiWrapper.DTO;
//
//    var data = AzureStorageInformation.FromJson(jsonString);
using Newtonsoft.Json;

namespace OnlineManagementApiWrapper.DTO
{
    public partial class AzureStorageInformation
    {
        [JsonProperty("StorageAccountKey")]
        public string StorageAccountKey { get; set; }

        [JsonProperty("ContainerName")]
        public string ContainerName { get; set; }

        [JsonProperty("StorageAccountName")]
        public string StorageAccountName { get; set; }
    }

    public partial class AzureStorageInformation
    {
        public static AzureStorageInformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AzureStorageInformation>(json, Converter.Settings);
        }
    }
}
