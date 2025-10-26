using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanLowCommand : Command
    {
        private readonly CeilingFan ceilingFan;
        private readonly Stack<int> prevSpeeds = new Stack<int>();

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Low();
        }

        public void Undo()
        {
            if (prevSpeeds.Count == 0)
            {
                ceilingFan.Off();
                return;
            }

            int prev = prevSpeeds.Pop();
            Restore(prev);
        }

        private void Restore(int speed)
        {
            switch (speed)
            {
                case CeilingFan.HIGH:
                    ceilingFan.High();
                    break;
                case CeilingFan.MEDIUM:
                    ceilingFan.Medium();
                    break;
                case CeilingFan.LOW:
                    ceilingFan.Low();
                    break;
                default:
                    ceilingFan.Off();
                    break;
            }
        }

        public override string ToString()
        {
            return "CeilingFan Low";
        }
    }
}
