using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialRecursion
{
    public class Factorial
    {
        public int Calculate(int value)
        {
            int partialValue = value;

            // early return
            if (value == 0)
            {
                return 1;
            }

            Console.WriteLine(value);            

            return value * Calculate(value-1);
        }

    }
}
