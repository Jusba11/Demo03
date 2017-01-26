using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();
            pesukone.Temp = 60;
            pesukone.Duration = 120;
            pesukone.Speed = 10000;

            Console.WriteLine("Pesukoneen lämpötila on: " + pesukone.Temp);
            Console.WriteLine("Pesuohjelman kesto on: " + pesukone.Duration);
            Console.WriteLine("Pesukoneen linkousnopeus on: " + pesukone.Speed);

            pesukone.WashEnd();
        }
    }
}
