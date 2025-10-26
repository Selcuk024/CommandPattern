using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanOffCommand : Command
    {
        private readonly CeilingFan ceilingFan;
        private readonly Stack<int> prevSpeeds = new Stack<int>();

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeeds.Push(ceilingFan.GetSpeed());
            ceilingFan.Off();
        }

        public void Undo()
        {
            if (prevSpeeds.Count == 0)
            {
                ceilingFan.Off();
                return;
            }

            int prev = prevSpeeds.Pop();
            switch (prev)
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
            return "CeilingFan Off";
        }
    }
}
