using Newtonsoft.Json;

namespace OnlineManagementApiWrapper.DTO
{
    public static class Serialize
    {
        public static string ToJson(this BackupRequest self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
