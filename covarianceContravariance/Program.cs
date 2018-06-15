using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covarianceContravariance
{
    class Program
    {

        public delegate Person CovarianceDel();

        public static Employee GetInfo() { return new Employee() { Age = 23, CompanyName = "ACME Inc" }; }

        public delegate void ContraDel(Employee p);

        public static void PrintEmp(Person e) { Console.WriteLine(e.Age); }

        static void Main(string[] args)
        {
            CovarianceDel d = GetInfo;

            Console.WriteLine("Covariance.... !!");
            Console.Write(d().Age); //Covariance  : Able to call method with return type is derived form which is defined by delegate

            Console.ReadLine();


            Console.WriteLine("Contravariance.... !!");
            Employee emp = new Employee() { Age = 23, CompanyName = "Acme Inc" };
            ContraDel c2 = PrintEmp;

            c2(emp);

            Console.ReadKey();
        }
    }



    public class Person
    {
        public int Age { get; set; }
    }

    public class Employee : Person
    {
        public string CompanyName { get; set; }
    }
}
