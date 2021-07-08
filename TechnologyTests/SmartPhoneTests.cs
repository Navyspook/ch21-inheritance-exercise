using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        SmartPhone smartphone1;

        [TestInitialize]
        public void CreateSmartPhoneObject()
        {
            smartphone1 = new SmartPhone("JJ's Phone", 100_100_100_102, "Samsung", 867_5309);
        }

        //7
        [TestMethod]
        public void ConstructorSetsPhoneNumber()
        {
            Assert.AreEqual(smartphone1.PhoneNumber, 867_5309);
        }

        //8
        [TestMethod]
        public void ConstructorSetsIPAddress()
        {
            Assert.AreEqual(smartphone1.IpAddress, 100_100_100_102);
        }

        //9
        [TestMethod]
        public void ConstructorSetsMake()
        {
            Assert.AreEqual(smartphone1.Make, "Samsung");
        }

        ////10
        //[TestMethod]
        //public void ChangeWifiNameSetsWifiName()
        //{
        //    laptop1.ChangeWifiName("Public Wifi");
        //    Assert.AreEqual(laptop1.WifiName, "Public Wifi");
        //}
    }
}
