using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public string WifiName { get; set; }


        public string ChangeWifiName(string newWifiName)
        {
            WifiName = newWifiName;
            return WifiName;
        }


        public Laptop(string name, long ipAddress, string make, string wifiName)
            : base(name, ipAddress, make)
        {
            WifiName = wifiName;
        }
            
    }
}
