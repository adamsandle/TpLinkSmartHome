using System;
using System.Net;
using AutoMapper;
using TpLinkSmartHome.models;

namespace TpLinkSmartHome
{
    public abstract class Device
    {
        private readonly IMapper _mapper = MapConfigurations.Configs().CreateMapper();
        protected Device(string ipAddress)
        {
            if (!IPAddress.TryParse(ipAddress, out var ip))
            {
                throw new Exception("Invalid IP");
            };
            IpAddress = ipAddress;
        }
        public string IpAddress { get; }

        protected dynamic SysInfo<T>()
        {
            var response = SendCommand<Response>(Commands.SysInfo());
            return _mapper.Map<Response, T>(response);
        }

        protected dynamic SendCommand(string command)
        {
            return SendCommand<dynamic>(command);
        }

        private T SendCommand<T>(string command)
        {
            if(GetType() == typeof(Plug))
            {
                return Utils.SendToSmartPlugOrSwitch<T>(IpAddress, command);
            };
            return default(T);
        }
    }

    public class Plug : Device
    {

        public Plug(string ipAddress) : base(ipAddress)
        {
        }

        public PlugSystemInfo SysInfo()
        {
            return base.SysInfo<PlugSystemInfo>();
        }

        public void SetPowerState(bool powerState)
        {
            SendCommand(Commands.SetPowerState(powerState));
        }

        public void TogglePowerState()
        {
            SetPowerState(!SysInfo().PowerState);
        }
    }
}
