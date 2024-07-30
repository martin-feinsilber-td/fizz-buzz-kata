using NSubstitute;
using NUnit.Framework;

namespace Tests.Editor
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Return_Same_Number(int input)
        {
            //arrange
            var fizzBuzz = new FizzBuzz();
            //act
            var result = fizzBuzz.Execute(input);
            //assert
            Assert.AreEqual(input.ToString(), result);
        }
    }

    public class FizzBuzz
    {
        public string Execute(int input)
        {
            return input.ToString();
        }
    }
}