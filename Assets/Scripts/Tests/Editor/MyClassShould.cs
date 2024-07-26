using DefaultNamespace;
using NUnit.Framework;

namespace Tests.Editor
{
    [TestFixture]
    public class MyClassShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        public void When_NumberIsNotDivisible_ReturnNumber(int number, string result)
        {
            Assert.AreEqual(result, FizzBuzzKata.ConvertNumber(number));
        }
        
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(27)]
        public void When_NumberIsDivisibleBy3_ReturnFizz(int number)
        {
            Assert.AreEqual("Fizz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void When_NumberIsDivisibleBy5_ReturnBuzz(int number)
        {
            Assert.AreEqual("Buzz", FizzBuzzKata.ConvertNumber(number));
        }
        
        [TestCase(15)]
        [TestCase(60)]
        [TestCase(90)]
        public void When_NumberIsDivisibleBy5and3_ReturnFizzBuzz(int number)
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(13)]
        [TestCase(31)]
        public void When_NumberContains3_ReturnFizz(int number)
        {
            Assert.AreEqual("Fizz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(55)]
        [TestCase(59)]
        public void When_NumberContains5_ReturnBuzz(int number)
        {
            Assert.AreEqual("Buzz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(35)]
        [TestCase(51)]
        public void When_NumberContains3and5_ReturnFizzBuzz(int number)
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(7)]
        [TestCase(61)]
        public void When_SumOfDigitIs7_ReturnWhizz(int number)
        {
            Assert.AreEqual("Whizz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(43)]
        [TestCase(34)]
        public void When_SumOfDigitIs7AndContains3_ReturnFizzWhizz(int number)
        {
            Assert.AreEqual("FizzWhizz", FizzBuzzKata.ConvertNumber(number));
        }

        [TestCase(25)]
        [TestCase(52)]
        public void When_SumOfDigitIs7AndContains5_ReturnBuzzWhizz(int number)
        {
            Assert.AreEqual("BuzzWhizz", FizzBuzzKata.ConvertNumber(number));
        }
    }
}