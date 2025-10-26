using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandPattern.Classes.Commands
{
    internal class NoCommand : Command
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }

        public override string ToString()
        {
            return "NoCommand";
        }
    }
}
