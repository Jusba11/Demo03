using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.isOn = true;
            kiuas.Temp = 140;
            kiuas.Humi = 10.0;
            kiuas.ThrowWater();
            Console.WriteLine("Lämpötila on: " + kiuas.Temp);
            Console.WriteLine("Kosteus on: " + kiuas.Humi);
        }
    }
}
