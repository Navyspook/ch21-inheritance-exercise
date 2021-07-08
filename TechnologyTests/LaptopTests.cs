using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {
        Laptop laptop1;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            laptop1 = new Laptop("JJ's Laptop", 100_100_100_101, "Samsung", "JJ's Wifi");
        }

        [TestMethod]
        public void ConstructorSetsName()
        {
            Assert.AreEqual(laptop1.Name, "JJ's Laptop");
        }

        //5
        [TestMethod]
        public void ConstructorSetsWifiName()
        {
            Assert.AreEqual(laptop1.WifiName, "JJ's Wifi");
        }

        //6
        [TestMethod]
        public void ChangeWifiNameSetsWifiName()
        {
            laptop1.ChangeWifiName("Public Wifi");
            Assert.AreEqual(laptop1.WifiName, "Public Wifi");
        }
    }
}