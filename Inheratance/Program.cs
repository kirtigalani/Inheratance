using System;

namespace Inheratance
{
    public class Parents
    {
        public Parents()
        {
            Console.WriteLine("ParentClass constructor called");

        }
        public Parents(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class child : Parents
    {
        public child() : base("Derived class constrolling parent class")
        {
            Console.WriteLine("child class constructor called");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            child C = new child();  

        }
    }
}
