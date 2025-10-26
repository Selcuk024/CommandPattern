using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class GarageDoorDownCommand : Command
    {
        private readonly GarageDoor door;
        public GarageDoorDownCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Down();
        }

        public void Undo()
        {
            door.Up();
        }

        public override string ToString()
        {
            return "GarageDoor Down";
        }
    }
}
