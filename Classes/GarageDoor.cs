using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class GarageDoor
    {
        Light light;
        public GarageDoor(Light light)
        {
            this.light = light;
        }
        public void Up()
        {
            Console.WriteLine("Door is open");
        }

        public void Down()
        {
            Console.WriteLine("Door is closed");
        }

        public void Stop()
        {
            Console.WriteLine("Door stopped moving");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage door");
            light.On();
        }

        public void LightOff()
        {
            Console.WriteLine("Garage door");
            light.On();
        }
    }
}
