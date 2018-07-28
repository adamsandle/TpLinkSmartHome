using System;
using FluentAssertions;
using Xunit;

namespace TpLinkSmartHome.Tests
{
    public class DeviceTests
    {
        [Fact]
        public void PlugIsCreatedCorrectly()
        {
            var plug = new Plug("10.0.0.2");
            plug.IpAddress.Should().Be("10.0.0.2");
        }

        [Fact]
        public void CreatePlugWithInvalidIpThrowsException()
        {
            Assert.Throws<Exception>(() => new Plug("10.0.0.a"));
        }
    }
}
