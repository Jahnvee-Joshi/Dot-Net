using System;

namespace temperatureConverot
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Press 1 for Centigrade to Fahrenheit");
            Console.WriteLine("Press 2 for  to Fahrenheit to Centigrade");
            option = int.Parse(Console.ReadLine());
            tempConvertor(option);
            Console.Read();
        }
        public static void tempConvertor(int option)
        {
            float centigrade, fahrenheit;
            switch (option)
            {
                case 1:                    
                    Console.Write("Enter temperature in centigrade(°C):  ");
                    centigrade = float.Parse(Console.ReadLine());
                    fahrenheit = centigrade * 9 / 5 + 32;
                    Console.WriteLine($"{centigrade}°C = {fahrenheit}°F");
                    break;
                case 2:
                    Console.Write("Enter temperature in fahrenheit(°F):  ");
                    fahrenheit = float.Parse(Console.ReadLine());
                    centigrade = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit}°F = {centigrade}°C");
                    break;
            }
        }
    }
}
