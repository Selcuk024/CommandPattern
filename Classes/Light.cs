using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Light
    {
        private string location;
        public Light(string location)
        {
            this.location = location;
        }
        public void On()
        {
            Console.WriteLine($"{location} Light is turned on");
        }

        public void Off()
        {
            Console.WriteLine($"{location} Light is turned off");

        }
    }
}
