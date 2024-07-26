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
        [TestCase(52)]
        public void When_NumberContains5_ReturnBuzz(int number)
        {
            Assert.AreEqual("Buzz", FizzBuzzKata.ConvertNumber(number));
        }
    }
}