using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }


        // ****************************** Add(double a, double b) ******************************
        [TestCase(2, 4, 6)]
        [TestCase(4, 2, 6)]
        [TestCase(-1, 3, 2)]
        [TestCase(3, -1, 2)]
        [TestCase(1, 1, 2)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        // ****************************** Add(double addend) ******************************
        [TestCase(2, 4, 6, 12)]
        [TestCase(2, 4, -6, 0)]
        [TestCase(0, 0, 0, 0)]
        public void Add_AddPosAndNegNumbersWithOneArgument_ResultIsCorrect(double a, double b, double addend, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Add(addend), Is.EqualTo(result));
        }

        // ****************************** Subtract(double a, double b) ******************************
        [TestCase(4, 2, 2)]
        [TestCase(2, 4, -2)]
        [TestCase(-1, 2, -3)]
        [TestCase(2, -1, 3)]
        [TestCase(-5, -5, 0)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        // ****************************** Subtract(double subtractor) ******************************
        [TestCase(5, 2, 2, 1)]
        [TestCase(2, 5, -2, -1)]
        [TestCase(0, 0, 0, 0)]
        public void Subtract_SubtractPosAndNegNumbersWithOneArgument_ResultIsCorrect(double a, double b, double subtractor, double result)
        {
            _uut.Subtract(a, b);
            Assert.That(_uut.Subtract(subtractor), Is.EqualTo(result));
        }

        // ****************************** Multiply(double a, double b) ******************************
        [TestCase(0, 2, 0)]
        [TestCase(2, 0, 0)]
        [TestCase(3, 2, 6)]
        [TestCase(2, 3, 6)]
        [TestCase(-1, 2, -2)]
        [TestCase(2, -1, -2)]
        [TestCase(-5, -5, 25)]
        public void Multiply_MultiplyPosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        // ****************************** Multiply(double multiplier) ******************************
        [TestCase(2, 2, 0, 0)]
        [TestCase(2, 2, 2, 8)]
        [TestCase(3, -2, -2, 12)]
        public void Multiply_MultiplyPosAndNegNumbersWithOneArgument_ResultIsCorrect(double a, double b, double multiplier, double result)
        {
            _uut.Multiply(a, b);
            Assert.That(_uut.Multiply(multiplier), Is.EqualTo(result));
        }

        // ****************************** Divide(double dividend, double divisor) ******************************
        [TestCase(10, 10, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 0.5)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(2, -1, -2)]
        [TestCase(-5, -5, 1)]
        public void Divide_DividePosAndNegNumbers_ResultIsCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo((result)));
        }

        // ****************************** Divide(double divisor) ******************************
        [TestCase(10, 10, 1, 1)]
        [TestCase(4, 2, -2, -1)]
        [TestCase(0, 2, 2, 0)]
        public void Divide_DividePosAndNegNumbersWithOneArgument_ResultIsCorrect(double dividend, double divisorA, double divisorB, double result)
        {
            _uut.Divide(dividend, divisorA);
            Assert.That(_uut.Divide(divisorB), Is.EqualTo((result)));
        }

        // ****************************** DivideByZeroException() ******************************
        public void DivideByZeroException()
        {
            Assert.That(() => _uut.Divide(dividend: 5, divisor: 0), Throws.TypeOf<DivideByZeroException>());
        }


        // ****************************** Power(double a, double exp) ******************************
        [TestCase(0, 2, 0)]
        [TestCase(2, 0, 1)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-3, 2, 9)]
        [TestCase(-2, -2, 0.25)]
        [TestCase(3, 3, 27)]
        public void Power_PowerPosAndNegNumbers_ResultIsCorrect(double a, double exp, double result)
        {
            Assert.That(_uut.Power(a, exp), Is.EqualTo(result));
        }

        // ****************************** Power(double exponent) ******************************
        [TestCase(2, 2, 2, 16)]
        [TestCase(2, 2, -2, 0.0625)]
        [TestCase(2, 2, 0, 1)]
        public void Power_PowerPosAndNegNumbersWIthOneArgument_ResultIsCorrect(double a, double exp, double exponent, double result)
        {
            _uut.Power(a, exp);
            Assert.That(_uut.Power(exponent), Is.EqualTo(result));
        }

        // ****************************** Accumulator ******************************
        [TestCase(0, 0, 0)]
        [TestCase(-1, -3, -4)]
        [TestCase(-3, -1, -4)]
        [TestCase(12, -2, 10)]
        [TestCase(-2, 12, 10)]
        public void Accumulator_AccumulatorEqualToResultFromAddFunction(double a, double b, double accuValue)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(accuValue));
        }

        // ****************************** Clear() ******************************
        [TestCase(1, 1)]
        [TestCase(1, -2)]
        [TestCase(-2, 1)]
        public void Clear_SetAccumulatorToZero(double a, double b)
        {
            _uut.Add(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
    }
}
