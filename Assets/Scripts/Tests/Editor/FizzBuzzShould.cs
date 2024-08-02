using NSubstitute;
using NUnit.Framework;

namespace Tests.Editor
{
    [TestFixture]
    public class FizzBuzzShould
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestCase(1)]
        [TestCase(2)]
        public void Print_The_Same_Number(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual(input.ToString(), value);
        }

        [TestCase(3)]
        [TestCase(9)]
        public void Print_Fizz_When_Divisible_By_Three(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("Fizz", value);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void Print_Buzz_When_Divisible_By_Five(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("Buzz", value);
        }

        [TestCase(15)]
        [TestCase(30)]
        public void Print_FizzBuzz_When_Divisible_By_Three_And_Five(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("FizzBuzz", value);
        }

        [TestCase(13)]
        public void Print_Fizz_When_Has_Three_In_It(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("Fizz", value);
        }

        [TestCase(52)]
        public void Print_Buzz_When_Has_Five_In_It(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("Buzz", value);
        }

        [TestCase(53)]
        public void Print_FizzBuzz_When_Has_Three_And_Has_Five_In_It(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("FizzBuzz", value);
        }

        [TestCase(51)]
        public void Print_FizzBuzz_When_Divisble_By_Three_And_Has_Five_In_It(int input)
        {
            var value = fizzBuzz.GetElement(input);
            Assert.AreEqual("FizzBuzz", value);
        }
    }
}