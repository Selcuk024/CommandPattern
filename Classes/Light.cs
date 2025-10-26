using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Light
    {
        private readonly string location;
        private bool isOn;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            isOn = true;
            Console.WriteLine($"{location} light is ON");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine($"{location} light is OFF");
        }

        public bool IsOn() => isOn;
    }
}
