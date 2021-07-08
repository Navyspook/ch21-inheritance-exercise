using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public string Name { get; set; }
        public long IpAddress { get; set; }
        public string Make { get; set; }
        public List<int> UniqueIDs{ get; set; }


        public void PrintInfo()
        {
            Console.WriteLine($"Device ID: {UniqueID} | Device Name: {this.Name} | IP Address: {this.IpAddress} | Make: {this.Make}");
        }

        public long ChangeIP(long newIP)
        {
            IpAddress = newIP;
            return IpAddress;
        }

        public void SendEmail(string emailAddress)
        {
            Console.WriteLine($"Email sent to {emailAddress}");
        }

        public Computer(string name, long ipAddress, string make)
        {
            this.Name = name;
            this.IpAddress = ipAddress;
            this.Make = make;         


        }
    }
}
