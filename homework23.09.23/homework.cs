using System;

namespace homework23._09._23
{
    
    enum weekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    internal class homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            double[] array = new double[10];
            Console.Write("Enter ten numbers: \n");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                bool result = array[i] < array[i + 1];

                if (result == true)
                {
                    Console.WriteLine("The subsequence is increasing.");
                }
                else 
                {
                    Console.WriteLine("Error. The subsequence is not increasing. The index of element:" + (i + 1));
                    break;
                }
            }

            Console.WriteLine("Task 2.");
            string[] cards = new string[9] { "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King", "Ace" };
            try
            {
                Console.WriteLine("Enter an integer:");
                string a = Console.ReadLine();
                bool res1 = int.TryParse(a, out int k);
                if (res1 == true)
                {
                    if (k >= 6 || k <= 14)
                    {
                        int i = k - 6;
                        Console.WriteLine("Card:" + cards[i]);
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong format.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Task 3\n");
            Console.WriteLine("Enter the word:");
            string word = Console.ReadLine();
            string word1 = word.ToLower();
            switch (word1)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school Counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("Task 4");
            Console.WriteLine("Enter one integer from 1 to 7:");
            string s = Console.ReadLine();
            bool res = int.TryParse(s, out int k1);
            switch (k1)
            {
                case 1:
                    weekDays day1 = weekDays.Monday;
                    Console.WriteLine($"{day1}");
                    break;
                case 2:
                    weekDays day2 = weekDays.Tuesday;
                    Console.WriteLine($"{day2}");
                    break;
                case 3:
                    weekDays day3 = weekDays.Wednesday;
                    Console.WriteLine($"{day3}");
                    break;
                case 4:
                    weekDays day4 = weekDays.Thursday;
                    Console.WriteLine($"{day4}");
                    break;
                case 5:
                    weekDays day5 = weekDays.Friday;
                    Console.WriteLine($"{day5}");
                    break;
                case 6:
                    weekDays day6 = weekDays.Saturday;
                    Console.WriteLine($"{day6}");
                    break;
                case 7:
                    weekDays day7 = weekDays.Sunday;
                    Console.WriteLine($"{day7}");
                    break;
                default:
                    Console.WriteLine("Error. Try again.");
                    break;
            }

            Console.WriteLine("Task 5\n");
            string[] things = { "Hello Kitty", "Barbie doll", "Barbie doll", "Barbie doll", "Hello Kitty", "Teddy bear", "Hello Kitty", "Hello Kitty", "Teddy bear" };
            int amount = 0;
            foreach (string b in things)
            {
                Console.WriteLine(b);
                if (b == "Barbie doll")
                {
                    amount++;
                }
            }
            Console.WriteLine("\nResult: " + amount);

            Console.WriteLine("(Press any key to continue work)");
            Console.ReadKey();

        }
    }
}
