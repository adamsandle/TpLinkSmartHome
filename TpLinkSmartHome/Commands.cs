using Newtonsoft.Json;

namespace TpLinkSmartHome
{
    internal static class Commands
    {
        public static string SetPowerState(bool powerState)
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    set_relay_state = new
                    {
                        state = powerState ? 1 : 0
                    }
                }
            });
        }

        public static string SysInfo()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    get_sysinfo = new
                    {
                    }
                }
            });
        }

        public static string SysInfoAndEmeter()
        {
            return JsonConvert.SerializeObject(new
            {
                system = new
                {
                    get_sysinfo = new
                    {
                    }
                },
                emeter = new
                {
                    get_realtime = new { },
                    get_vgain_igain = new { }
                }
            });
        }

        public static string Emeter()
        {
            return JsonConvert.SerializeObject(new
            {
                emeter = new
                {
                    get_realtime = new { },
                    get_vgain_igain = new { }
                }
            });
        }

        public static string MonthStats(int year)
        {
            return JsonConvert.SerializeObject(new
            {
                emeter = new
                {
                    get_monthstat = new { year = year },
                }
            });
        }
    }
}
