using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class Stereo
    {
        private readonly string location;
        private string? source = null;
        private int volume = 0;
        private bool isOn = false;

        public Stereo(string location)
        {
            this.location = location;
        }

        public void On()
        {
            isOn = true;
            Console.WriteLine($"{location} stereo is ON");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine($"{location} stereo is OFF");
        }

        public void SetCd()
        {
            source = "CD";
            Console.WriteLine($"{location} stereo set to CD");
        }

        public void SetDvd()
        {
            source = "DVD";
            Console.WriteLine($"{location} stereo set to DVD");
        }

        public void SetRadio()
        {
            source = "Radio";
            Console.WriteLine($"{location} stereo set to RADIO");
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
            Console.WriteLine($"{location} stereo volume set to {volume}");
        }

        public (bool on, string? src, int vol) State() => (isOn, source, volume);
    }
}
