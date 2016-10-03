using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NhibernateTutorial
{
     class Program
    {
        static void Main(string[] args)
        {
            NhibernateDataProvider obj = new NhibernateDataProvider();


            Console.WriteLine("Enter Id to display Employee Information");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Name of Employee is:");
            Console.WriteLine(obj.getEmployeeById(n).empName);

            Console.WriteLine("Age of Employee:");
            Console.WriteLine(obj.getEmployeeById(n).age);

            Console.WriteLine("City he lives in is:");
            Console.WriteLine(obj.getEmployeeById(n).city);

            Console.WriteLine("Salary is:");
            Console.WriteLine(obj.getEmployeeById(n).salary);

        }
    }
}
