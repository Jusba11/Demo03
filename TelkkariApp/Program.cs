using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelkkariApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            tv.Brightness = 300;
            tv.Volume = 5;
            tv.Channel = 1;
            tv.Guide = false;
            tv.isOn = false;

            do
            {
                do
                {
                    Console.Write("Turn TV on by pressing Y on your keyboard >");
                    string syote = Console.ReadLine();

                    if (syote == "Y" || syote == "y")
                    {
                        tv.isOn = true;
                    }

                } while (!tv.isOn);

                Console.Clear();

                tv.ShowStatus();
                tv.ShowMenu();

                do
                {
                    Console.Write("What do you what to do? press a corresponding key >");
                    int syote = int.Parse(Console.ReadLine());

                    switch (syote)
                    {
                        case 1:
                            Console.Write("Choose a channel: >");
                            syote = int.Parse(Console.ReadLine());
                            tv.ChangeChannel(syote); break;
                        case 2:
                            Console.Write("Choose new brightness level: >");
                            syote = int.Parse(Console.ReadLine());
                            tv.ChangeBrightness(syote); break; // brightness

                        case 3:
                            Console.Write("Choose new Volume level: >");
                            syote = int.Parse(Console.ReadLine());
                            tv.VolumeSet(syote); break;

                        case 4:
                            tv.ToggleGuide();
                            break;  //guide

                        case 0:
                            tv.isOn = false;
                            break; // turnOff
                    }

                    Console.Clear();
                    tv.ShowStatus();
                    tv.ShowMenu();

                } while (tv.isOn);

                Console.Clear();
                Console.WriteLine("TV IS NOW OFF!");

            } while (1 == 1);
        }
    }
}
