using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class StereoOnWithRadioCommand : Command
    {
        Stereo stereo;

        public StereoOnWithRadioCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetRadio();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }

    }
}

