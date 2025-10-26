using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CommandPattern.Classes
{
    internal class GarageDoor
    {
        private readonly string location;
        private bool isOpen;

        public GarageDoor(string location)
        {
            this.location = location;
        }

        public void Up()
        {
            isOpen = true;
            Console.WriteLine($"{location} garage door is OPEN");
        }

        public void Down()
        {
            isOpen = false;
            Console.WriteLine($"{location} garage door is CLOSED");
        }

        public void Stop()
        {
            Console.WriteLine($"{location} garage door STOPPED");
        }

        public void LightOn()
        {
            Console.WriteLine($"{location} garage door light is ON");
        }

        public void LightOff()
        {
            Console.WriteLine($"{location} garage door light is OFF");
        }

        public bool IsOpen() => isOpen;
    }
}
