namespace TpLinkSmartHome.models
{

    public abstract class DeviceSystemInfo
    {
        public string Alias { get; set; }
        public string Mac { get; set; }
        public Location Location { get; set; }
    }

    public class PlugSystemInfo : DeviceSystemInfo
    {
        public bool PowerState { get; set; }
    }
}
