using System;
using NUnit.Framework;

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


        // ****************************** Add() ******************************
        [TestCase(2, 4, 6)]
        [TestCase(4, 2, 6)]
        [TestCase(-1, 3, 2)]
        [TestCase(3, -1, 2)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        // ****************************** Subtract() ******************************
        [TestCase(4, 2, 2)]
        [TestCase(2, 4, -2)]
        [TestCase(-1, 2, -3)]
        [TestCase(2, -1, 3)]
        [TestCase(-5, -5, 0)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        // ****************************** Multiply() ******************************
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

        // ****************************** Divide() ******************************
        [TestCase(10, 10, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(2, 4, 0.5)]
        [TestCase(-1, 2, -0.5)]
        [TestCase(2, -1, -2)]
        [TestCase(-5, -5, 1)]
        [TestCase(3, 2, 1)]
        public void Divide_DividePosAndNegNumbers_ResultIsCorrect(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo((result)));
        }

        // ****************************** Power() ******************************
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
    }
}
