using System;

namespace Pattern
{
    class Program
    {
        static void Pattern1()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Pattern2()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void Pattern3()
        {
            for (int i = 5; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void Pattern4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1");
            Pattern1();
            Console.WriteLine("\n\n");
            Console.WriteLine("Pattern 2");
            Pattern2();
            Console.WriteLine("\n\n");
            Console.WriteLine("Pattern 3");
            Pattern3();
            Console.WriteLine("\n\n");
            Console.WriteLine("Pattern 4");
            Pattern4();
            Console.WriteLine("\n\n");

        }
    }
}
