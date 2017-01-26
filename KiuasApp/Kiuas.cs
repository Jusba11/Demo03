using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasApp
{
    class Kiuas
    {
        public bool isOn { get; set; }
        public int Temp { get; set; }
        public double Humi { get; set; }

        public void ThrowWater()
        {
            Console.WriteLine("AI SAAKELI EI ENÄÄ LISÄÄÄÄ!!!!");
        }
    }
}
