using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSharp.ChannelProperties;

namespace PrtgSharp.Tests.ChannelProperties
{
    [TestClass]
    public class ChannelShowChartOnFirstRunPropertyTests : ChannelPropertyTestsBase
    {
        [TestMethod]
        private static void AssertChannelProp(ChannelProperty channelProp, string value)
        {
            AssertChannelProp(channelProp, "showchart", value);
        }

        [TestMethod]
        public void Yes_Should_Be_ShowChart_1()
        {
            // Act
            var channelProp = ChannelShowChartOnFirstRunProperty.Yes;

            // Assert
            AssertChannelProp(channelProp, "1");
        }

        [TestMethod]
        public void Yes_Should_Be_ShowChart_0()
        {
            // Act
            var channelProp = ChannelShowChartOnFirstRunProperty.No;

            // Assert
            AssertChannelProp(channelProp, "0");
        }
    }
}