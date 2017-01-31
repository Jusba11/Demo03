using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskelijaApp
{
    class Opiskelija
    {
        public int Ika { get; set; }
        public double Keskiarvo { get; set; }
        public string Harrastus { get; set; }

        
        public void NautiOlut()
        {
            Console.WriteLine("Nams.");
        }

        public void Nuku()
        {
            Console.WriteLine("Zzzz..");
        }
        
    }
}
