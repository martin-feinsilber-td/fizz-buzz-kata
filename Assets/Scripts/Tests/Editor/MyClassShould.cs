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
            Assert.AreEqual(result, FizzBuzz.ConvertNumber(number));
        }
        
        [TestCase(3)]
        [TestCase(9)]
        [TestCase(27)]
        public void When_NumberIsDivisibleBy3_ReturnFizz(int number)
        {
            Assert.AreEqual("Fizz", FizzBuzz.ConvertNumber(number));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void When_NumberIsDivisibleBy5_ReturnBuzz(int number)
        {
            Assert.AreEqual("Buzz", FizzBuzz.ConvertNumber(number));
        }
        
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(300)]
        public void When_NumberIsDivisibleBy5and3_ReturnFizzBuzz(int number)
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.ConvertNumber(number));
        }
    }
}