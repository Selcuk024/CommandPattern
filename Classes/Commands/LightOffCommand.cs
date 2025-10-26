using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandPattern.Classes.Commands
{
    internal class LightOffCommand : Command
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }

        public override string ToString()
        {
            return $"{light.GetType().Name} Off";
        }
    }
}
