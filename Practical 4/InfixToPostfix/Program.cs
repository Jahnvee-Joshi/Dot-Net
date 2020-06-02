using System;

namespace InfixToPostfix
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter infix string");
            string infix = Console.ReadLine();
            //string infix = "a/b-c+d*e-a*c";
            string postfix = "";
            Class1 p = new Class1();
            p.InfixToPostFix(ref infix, out postfix);
        }
    }
}
