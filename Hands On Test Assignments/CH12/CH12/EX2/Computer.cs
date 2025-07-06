using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    public class Computer
    {
        private string _name;
        private string _ipAddress;
        private string _services;

        public Computer(string name, string ipAddress, string services)
        {
            _ipAddress = ipAddress;
            _services = services;
            _name = name;
        }

        public string getName()
        {
            return _name;
        }
        public string getIpAddress()
        {
            return _ipAddress;
        }
        public string getService()
        {
            return _services;
        }
    }
}
