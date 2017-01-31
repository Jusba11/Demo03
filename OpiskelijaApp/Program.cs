using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskelijaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija Matti = new Opiskelija();
            Matti.Harrastus = "Galj";
            Matti.Ika = 23;
            Matti.Keskiarvo = 1.2;

            Opiskelija Seppo = new Opiskelija();
            Seppo.Harrastus = "Golf";
            Seppo.Ika = 30;
            Seppo.Keskiarvo = 4.3;
            
            Opiskelija Jorma = new Opiskelija();
            Jorma.Harrastus = "Kalastus";
            Jorma.Ika = 12;
            Jorma.Keskiarvo = 5;
            
            Opiskelija Irma = new Opiskelija();
            Irma.Harrastus = "Juoksu";
            Irma.Ika = 35;
            Irma.Keskiarvo = 1;
            
            Opiskelija Kyllikki = new Opiskelija();
            Kyllikki.Harrastus = "Kudonta";
            Kyllikki.Ika = 98;
            Kyllikki.Keskiarvo = 4.6;

            string[] names = new string[5] { "Matti", "Seppo", "Jorma", "Irma", "Kyllikki" };

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
