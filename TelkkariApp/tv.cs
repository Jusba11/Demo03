using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkkariApp
{
    class Tv
    {
        public int Channel { get; set; }
        public int Volume { get; set; }
        public int Brightness { get; set; }
        public bool Guide { get; set; } // guide-tila päällä tai pois.
        public bool isOn { get; set; }

        public void PowerOn()
        {
            Console.WriteLine("TV IS NOW ON");
        }

        public void ToggleGuide()
        {
            if (!Guide)
            {
                Guide = true;
            }
            else
            {
                Guide = false;
            }
        }
        public void VolumeSet(int a)
        {
            Volume = a;
        }
        public void ChangeChannel(int b)
        {
            Channel = b;
        }
        
        public void ChangeBrightness(int c)
        {
            Brightness = c;
        }


        public void ShowStatus()
        {
            Console.WriteLine("TV IS NOW ON! \n");

            Console.WriteLine("TV brightness: " + Brightness);

            Console.WriteLine("TV Volume: " + Volume);

            Console.WriteLine("Channel: " + Channel);

            Console.WriteLine("is guide showing: " + Guide);
        }
        public void ShowMenu()
        {

            Console.WriteLine("\n\n\n1: Change the Channel");

            Console.WriteLine("2. Adjust Brightness");

            Console.WriteLine("3: Adjust Volume");

            Console.WriteLine("4: Toggle Guide");

            Console.WriteLine("0: Turn TV off.");
        }

    }
}
