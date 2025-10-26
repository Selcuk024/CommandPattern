using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        private readonly Command[] onCommands = new Command[7];
        private readonly Command[] offCommands = new Command[7];

        private readonly Stack<Command> history = new Stack<Command>();

        public RemoteControl()
        {
            NoCommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            if (slot < 0 || slot >= onCommands.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(slot));
            }

            if (onCommand == null)
            {
                throw new ArgumentNullException(nameof(onCommand));
            }

            if (offCommand == null)
            {
                throw new ArgumentNullException(nameof(offCommand));
            }

            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            history.Push(onCommands[slot]);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            history.Push(offCommands[slot]);
        }

        public void UndoButtonWasPushed()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            Command last = history.Pop();
            Console.WriteLine("Undoing last command");
            last.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Remote control");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.AppendLine($"[slot {i}] {onCommands[i],-24} {offCommands[i]}");
            }
            sb.AppendLine($"[history depth] {history.Count}");
            return sb.ToString();
        }
    }
}


