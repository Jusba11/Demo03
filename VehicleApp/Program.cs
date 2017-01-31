using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Name = "Ferrari";
            vehicle.Speed = 200;
            vehicle.Tyres = 4;

            string tiedot = vehicle.ToString(vehicle.Name, vehicle.Speed, vehicle.Tyres);
            Console.WriteLine(tiedot);


            vehicle.Name = "Volvo";
            vehicle.Speed = 10;
            vehicle.Tyres = 2;


            tiedot = vehicle.ToString(vehicle.Name, vehicle.Speed, vehicle.Tyres);
            Console.WriteLine(tiedot);


        }
    }
}
