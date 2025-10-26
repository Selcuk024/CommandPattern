using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class GarageDoorUpCommand : Command
    {
        private readonly GarageDoor door;

        public GarageDoorUpCommand(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Up();
        }

        public void Undo()
        {
            door.Down();
        }

        public override string ToString()
        {
            return "GarageDoor Up";
        }
    }
}
