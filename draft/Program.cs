using System;

namespace draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();
            
        }
    }
}
