using System;

namespace lab4
{

    internal class lab4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks 4.1. This program formats numbers in dates.");
            Console.WriteLine("Enter one integer from 1 to 365:");
            string a = Console.ReadLine();
            bool result = int.TryParse(a, out int num);

            if (result == true || num > 0 || num <= 365)
            {
                DateTime date = new DateTime(2023, 1, 1).AddDays(--num);
                Console.WriteLine(date.ToLongDateString());
                Console.WriteLine(date.ToString("dd.MM"));
            }
            else
            {
                Console.WriteLine("Error. Please, check entered number.");
            }

            Console.WriteLine("\nTask 4.2");
            try
            {
                Console.WriteLine("Enter one number from 1 to 365:");
                int num1 = Convert.ToInt16(Console.ReadLine());
                if (num1 <= 0 || num1 > 365)
                {
                    throw new Exception("Wrong format. Try again.");
                }
                DateTime date1 = new DateTime(2023, 1, 1).AddDays(--num1);
                Console.WriteLine(date1.ToLongDateString());
                Console.WriteLine(date1.ToString("dd.MM"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nHome task 4.3");
            Console.WriteLine("Enter year:");
            string b = Console.ReadLine();
            bool res = int.TryParse(b, out int year);
            Console.WriteLine("Enter one integer from 1 to 365 or 366:");
            string a1 = Console.ReadLine();
            bool result1 = int.TryParse(a1, out int num2);
            if (result1 == true || res == true)
            {
                if (DateTime.IsLeapYear(year) || num2 >= 0 || num2 <= 366)
                {
                    DateTime date3 = new DateTime(year, 1, 1).AddDays(--num2);
                    Console.WriteLine(date3.ToLongDateString());
                    Console.WriteLine(date3.ToString("dd.MM.yy"));
                }
                else if (num2 >= 0 || num2 <= 365)
                {
                    DateTime date2 = new DateTime(year, 1, 1).AddDays(--num2);
                    Console.WriteLine(date2.ToLongDateString());
                    Console.WriteLine(date2.ToString("dd.MM.yy"));
                }
            }
            else
            {
                Console.WriteLine("Error. Please, check entered number.");
            }

            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();
        }
    }
}
