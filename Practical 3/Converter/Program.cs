using System;

namespace Converter
{
    class Program
    {
        void decimalToBinary()
        {
            int deci = 10;
            Console.WriteLine("Decimal value is " + deci);
            int[] c = new int[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                c[i] = deci % 2;
                if (deci <= 1)
                {
                    break;
                }
                deci /= 2;
            }
            Console.WriteLine("Binary Value is ");
            int j = 0;
            for (j = i; j>=0; j--)
            {
                Console.Write(c[j]);
            }

            Console.WriteLine("");
        }
        void decimalToOctagal()
        {
            int deci = 10;
            Console.WriteLine("Decimal value is " + deci);
            int[] c = new int[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                c[i] = deci % 8;
                if (deci < 7)
                {
                    break;
                }
                deci /= 8;
            }

            int j = 0;

            Console.WriteLine("Ocatagal value is ");
            for (j = i ; j >= 0; j--)
            {
                Console.Write(c[j]);
            }
            Console.WriteLine("");
        }

        void decimalToHexa()
        {
            int deci = 10;
            Console.WriteLine("Decimal value is " + deci);
            char[] c = new char[50];
            int i = 0;
            for (i = 0; i < 50; i++)
            {
                int temp = 0;
                temp = deci % 16;
                if (temp < 10)
                {
                    c[i] =  Convert.ToChar(temp + 48);
                }
                else
                {
                    c[i] = Convert.ToChar(temp + 55);
                }
                if (deci < 15)
                {
                    break;
                }
                deci = deci / 16;
            }
            int j = 0;
            Console.WriteLine("Hexa value is ");
            for (j = i; j >= 0; j--)
            {
                Console.Write(c[j]);
            }
            Console.WriteLine("");
        }

        void binaryToDecimal()
        {
            int num, bin, deci = 0, baseval = 1, rem;
            num = 1010;
            bin = num;
            while (num > 0)
                {
                    rem = num % 10;
                    deci = deci + rem * baseval;
                    num = num / 10;
                    baseval = baseval * 2;
                }
            Console.Write("The Binary Number is : " + bin);
            Console.Write("\nIts Decimal Equivalent is : " + deci);
            Console.WriteLine("");
            Console.ReadLine();           
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.decimalToBinary();
            p.decimalToOctagal();
            p.decimalToHexa();
            p.binaryToDecimal();

        }
    }
}
