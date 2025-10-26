using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithCdCommand : Command
    {
        private readonly Stereo stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }

        public override string ToString()
        {
            return "Stereo on CD";
        }
    }
}
