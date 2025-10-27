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
        GarageDoor garageDoor;
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }
}