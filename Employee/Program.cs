using System;
using System.Runtime.CompilerServices;
using Employees.Entities;
using System.Globalization;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double addittionalCharge = double.Parse(Console.ReadLine());
                    emp.Add(new OutSourcedEmployee(name, hours, valuePerHour, addittionalCharge));
                }else if (ch == 'n'|| ch == 'N')
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("\nPayments: ");
            foreach(Employee employee in emp)
            {
                Console.WriteLine($"{employee.Name} - R$ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
