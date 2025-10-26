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
        private readonly Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var cmd in commands)
            {
                cmd.Execute();
            }
        }

        public void Undo()
        {
            for (int i = commands.Length - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
        }

        public override string ToString()
        {
            return $"MacroCommand[{commands.Length}]";
        }
    }
}
