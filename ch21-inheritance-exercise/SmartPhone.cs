using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public int PhoneNumber { get; set; }


        public void MakePhoneCall(int phoneNumber)
        {
            Console.WriteLine($"Now dialing {phoneNumber}...");
        }


        public SmartPhone(string name, long ipAddress, string make, int phoneNumber)
            : base(name, ipAddress, make)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
