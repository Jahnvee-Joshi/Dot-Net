﻿using System;

namespace digitToWords
{
    class Program
    {
        static string[] tens = new string[] { "", "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] words = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                                            "Eleven", "Twelve", "Thrteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen"};
        static string[] denomination = { "Hundred", "Thousand", "Lac", "Crore" };
        static void Main(string[] args)
        {
            int digits;
            bool flag = true;
            string numberString;
            string numberInWords = "";
            do
            {
                do
                {
                    if (flag == false)
                        Console.WriteLine("Please enter a valid decimal number or 'q' to EXIT");
                    numberString = Console.ReadLine();
                    if (numberString == "q")
                        System.Environment.Exit(0);
                    flag = false;
                } while (!int.TryParse(numberString, out digits));
                numberString = numberString.TrimStart('0');

                if (numberString.Length < 3)
                    numberInWords = upToTwoDigits(numberString);
                else if (numberString.Length < 4 && numberString.Length >=3)
                    numberInWords = threeDigits(numberString);
                else if (numberString.Length < 6 && numberString.Length >=4)
                    numberInWords = upToFiveDigits(numberString);
                else if (numberString.Length < 8 && numberString.Length >=6)
                    numberInWords = upToSevenDigits(numberString);
                else if (numberInWords.Length < 10 && numberString.Length >=8)
                    numberInWords = upToNineDigits(numberString);

                Console.WriteLine(numberInWords);
                numberInWords = "";
            } while (true);
        }

        private static string upToNineDigits(string numberString)
        {
            string c = "return something";
            /*if (numberString.Length == 9)
                 return upToTwoDigits(numberString.Substring(0, 1)) + " " + denomination[3] + " " + upToSevenDigits(numberString.Substring(1));
             else
                 return upToTwoDigits(numberString.Substring(0, 2)) + " " + denomination[3] + " " + upToSevenDigits(numberString.Substring(2));*/
            return c;
        }

        private static string upToSevenDigits(string numbeString)
        {
            string lacs;
            string thousands;
            string hundreds;

            if (numbeString.Length == 6)
                lacs = upToTwoDigits(numbeString.Substring(0, 1)) + " " + denomination[2];
            else
                lacs = upToTwoDigits(numbeString.Substring(0, 2)) + " " + denomination[2];

            thousands = upToTwoDigits(numbeString.Substring(1, 2));
            if (thousands != "")
                thousands += " " + denomination[1];

            hundreds = threeDigits(numbeString.Substring(3));

            return $"{lacs} {thousands} {hundreds}";
        }

        private static string upToFiveDigits(string numbeString)
        {
            if (numbeString.Length == 4)
                return upToTwoDigits(numbeString.Substring(0, 1)) + " " + denomination[1] + " " + threeDigits(numbeString.Substring(1));
            else
                return upToTwoDigits(numbeString.Substring(0, 2)) + " " + denomination[1] + " " + threeDigits(numbeString.Substring(2));
        }

        public static string threeDigits(string numbeString)
        {
            int digits = int.Parse(numbeString);
            if (digits != 0)
                return words[digits / 100] + " " + (digits / 100 == 0 ? "" : denomination[0]) + " " + upToTwoDigits(numbeString.Remove(0, 1));
            else
                return "";
        }
        private static string upToTwoDigits(string numberString)
        {
            int digits = int.Parse(numberString);

            if (digits < 20)
            {
                return words[digits];
            }
            else if (numberString[1] == '0')
            {
                return tens[digits / 10];
            }
            else if (digits > 20 && digits < 100)
            {
                return tens[digits / 10] + " " + words[digits % 10];
            }
            return "";
        }
    }
}
