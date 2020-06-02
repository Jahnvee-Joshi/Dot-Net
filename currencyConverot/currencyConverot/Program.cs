using System;
using System.Globalization;

namespace currencyConverot
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal franc, rupees, dollar, euro;
            string C ="";
            Console.WriteLine("Enter the rupees for the convertion");
            rupees = decimal.Parse(Console.ReadLine());
           
            dollar = 0.0135231M * rupees;
            euro = 0.0119462M * rupees;
            franc = 0.0784678M * rupees;
            Console.WriteLine($"{rupees}INR = {dollar.ToString("C",new CultureInfo("en-US"))}");
            Console.WriteLine($"{rupees}INR = {franc.ToString("C", new CultureInfo("de-CH"))}");
            Console.WriteLine($"{rupees}INR = {euro.ToString("C", new CultureInfo("en-GB"))}");
        }
    }
}
