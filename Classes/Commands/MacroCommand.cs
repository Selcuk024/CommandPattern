using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (Command c in commands)
            {
                c.Execute();
            }
        }

        public void Undo()
        {
            foreach (Command c in commands)
            {
                c.Undo();
            }
        }

        public override string ToString()
        {
            return $"MacroCommand[{commands.Length}]";
        }
    }
}
