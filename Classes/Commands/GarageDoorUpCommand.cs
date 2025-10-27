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
        GarageDoor garageDoor;
        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }
}