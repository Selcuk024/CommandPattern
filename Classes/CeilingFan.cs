using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace CommandPattern.Classes
{
    internal class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private readonly string location;
        private int speed = OFF;

        public CeilingFan(string location)
        {
            this.location = location;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine($"{location} ceiling fan set to HIGH");
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"{location} ceiling fan set to MEDIUM");
        }

        public void Low()
        {
            speed = LOW;
            Console.WriteLine($"{location} ceiling fan set to LOW");
        }

        public void Off()
        {
            speed = OFF;
            Console.WriteLine($"{location} ceiling fan is OFF");
        }

        public int GetSpeed() => speed;
    }
}
