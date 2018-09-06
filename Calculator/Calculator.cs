using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        // Accumulator is an automatic property, contains a variable which holds result of last operation
        public double Accumulator { get; private set; } = 0.0; // Default value is set to 0.0

        public void Clear()
        {
            Accumulator = 0.0;
        }

        // ****************************** Add() ******************************
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }
        
        // ****************************** Subtract() ******************************
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        // ****************************** Multiply() ******************************
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        // ****************************** Divide() ******************************
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator /= divisor;
            return Accumulator;
        }

        // ****************************** Power() ******************************
        public double Power(double a, double exp)
        {
            Accumulator = Math.Pow(a, exp);
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }
        
    }
}
