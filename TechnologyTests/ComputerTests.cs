using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;
using System;


namespace TechnologyTests
{
    [TestClass]
    public class ComputerTests
    {
        Computer computer1;
        //SmartPhone smartphone1;

        [TestInitialize]
        public void CreateComputerObject()
        {
            computer1 = new Computer("JJ's PC", 100_100_100_100, "HP");      
           
        }


        //1
        [TestMethod]
        public void ConstructorSetsName()
        {            
            Assert.AreEqual(computer1.Name, "JJ's PC");
        }

        //2
        [TestMethod]
        public void ConstructorSetsIpAddress()
        {
            Assert.AreEqual(computer1.IpAddress, 100_100_100_100);
        }

        //3
        [TestMethod]
        public void ConstructorSetsMake()
        {
            Assert.AreEqual(computer1.Make, "HP");
        }

        //4
        [TestMethod]
        public void ChangeIpAddressSetsNewIP()
        {
            computer1.ChangeIP(200_100_100_100);
            Assert.AreEqual(computer1.IpAddress, 200_100_100_100);
        }

 
    }
}
