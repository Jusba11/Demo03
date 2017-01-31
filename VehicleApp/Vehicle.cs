using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Vehicle name: " + Name);
            Console.WriteLine("Vehicle speed: " + Speed);
            Console.WriteLine("Number of tyres: " + Tyres);
        }

        public string ToString(string Name, int Speed, int Tyres)
        {
            return Name + " " + Speed + " " + Tyres;
        }
    }
}
