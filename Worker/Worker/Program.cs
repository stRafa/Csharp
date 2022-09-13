using System;
using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What department do you work? ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double bSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dpt = new Departament(dptName);
            Worker worker = new Worker(dptName, bSalary, level, dpt);

            Console.Write("How many contract for this worker? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write($"\nEnter #{i} contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int duration = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                HourContract contract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(contract);
            }
            Console.WriteLine("\n Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine($"Income for {month}/{year}: " + worker.Income(year, month));


        }
    }
}
