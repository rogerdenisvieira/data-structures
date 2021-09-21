using System;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var recursion = new Factorial();

            Console.WriteLine("Value:" + recursion.Calculate(5));
        }
    }
}
