using System;

namespace iSalesman
{
    interface iSalesman
    {
        public void Sell()
        {
            Console.WriteLine("This is normal class");
        }
    }
    class CarSalesman : iSalesman
    {
        private string firstName;
        private string lastName;
        public CarSalesman(string first, string last) 
        {
            firstName = first;
            lastName = last;
        }
        public void Sell()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName + " and I suggest you to buy this car");
        }
    }
    class RetailSalesman : iSalesman
    {
        private string firstName;
        private string lastName;
        public RetailSalesman(string first, string last) 
        {
            firstName = first;
            lastName = last;
        }
        public void Sell()
        {
            Console.WriteLine("Using interface My name is " + firstName + " " + lastName + " and I suggest you to buy this pen");
        }

    }
    class Progam
    {
        static void Main(string[] args)
        {
            CarSalesman c = new CarSalesman("Jahnvee", "Joshi");
            RetailSalesman r = new RetailSalesman("Jayshree", "Joshi");
            c.Sell();
            r.Sell();
        }
    }
}
