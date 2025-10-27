using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo was turned on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo was turned off");
        }

        public void SetCD()
        {
            Console.WriteLine("Stereo was turned to CD mode");
        }

        public void SetDVD()
        {
            Console.WriteLine("Stereo was turned to DVD mode");
        }
        public void SetRadio()
        {
            Console.WriteLine("Stereo was turned to Radio mode");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Stereo volume set to" + volume);
        }
    }
}