using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine($"Add(2,3) = {calc.Add(2,3)}");
            Console.WriteLine($"Subtract(2,3) = {calc.Subtract(2, 3)}");
            Console.WriteLine($"Multiply(2,3) = {calc.Multiply(2, 3)}");
            Console.WriteLine($"Power(2,3) = {calc.Power(2, 3)}");
        }
    }
}
