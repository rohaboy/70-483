using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit2
{

    interface IGasVehicle
    {
        void Move();
    }


    interface IElectricVehicle
    {
        void Move();
    }

    class Car : IGasVehicle, IElectricVehicle
    {
        void IElectricVehicle.Move()
        {
            Console.WriteLine("Moving needs Battery Power...");
        }

        void IGasVehicle.Move()
        {
            Console.WriteLine("Moving needs Gas Power...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IGasVehicle car1 = (IGasVehicle)(new Car());
            car1.Move();

            IElectricVehicle car2 = (IElectricVehicle)(new Car());
            car2.Move();


            Console.ReadKey();
        }
    }
}
