using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApp
{
    class Pesukone
    {
        public int Temp { get; set; }
        public int Speed { get; set; }
        public int Duration { get; set; }

        public void WashEnd()
        {
            Console.WriteLine("PIIIIP!! PESU VALMIS!");
        }
    }
}
