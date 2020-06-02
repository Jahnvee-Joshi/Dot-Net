using System;
using System.Text.RegularExpressions;

namespace Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string firstName, country;
                Console.WriteLine("Enter your name");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter your Country");
                country = Console.ReadLine();
                if (!((Regex.IsMatch(firstName,@"^[a-zA-Z]+$")) && (Regex.IsMatch(country,@"^[a-zA-Z]+$"))))
                 {
                    Console.WriteLine("Please Enter correct information");
                    continue;
                }
                else
                {
                    Console.WriteLine("Welcome " + firstName + " from country " + country);
                    break;
                }

            }
            Console.Read();
        }
    }
}
