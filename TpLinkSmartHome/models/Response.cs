using Newtonsoft.Json;

namespace TpLinkSmartHome.models
{
    internal class Response
    {
        [JsonProperty(PropertyName = "system")]
        public SystemReponse System { get; set; }
    }

    internal class SystemReponse
    {
        [JsonProperty(PropertyName = "get_sysinfo")]
        public SystemInfoResponse SystemInfo { get; set; }
    }

    internal class SystemInfoResponse
    {
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }
        [JsonProperty(PropertyName = "mac")]
        public string Mac { get; set; }
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }
        [JsonProperty(PropertyName = "latitude")]
        public float Latitude { get; set; }
        [JsonProperty(PropertyName = "longitude")]
        public float Longitude { get; set; }
        [JsonProperty(PropertyName = "relay_state")]
        public int RelayState { get; set; }

    }
}
