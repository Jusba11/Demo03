using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance from car class.
            Car car = new Car();
            car.Model = "Datsun 100A";
            car.Color = "Nigerian Black";
            car.Engine = 1.0;
            car.Speed = 120;
            car.FuzzyDice = true;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            Car.SomeProperty = 12;
            car.Brake(50);
            car.PrintData();

            //create another car.
            string model = "Speedster";
            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Color = "MUSTA";
            Console.WriteLine("Nascar color is: " + nascar.Color);
        }
    }
}
