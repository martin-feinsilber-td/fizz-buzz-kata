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
            //arrange
            fizzBuzz = new FizzBuzz();
        }
        
        [TestCase(1)]
        [TestCase(2)]
        public void Return_Same_Number(int input)
        {
            //act
            var result = fizzBuzz.Execute(input);
            //assert
            Assert.AreEqual(input.ToString(), result);
        }
        
        [TestCase(3)]
        public void Return_Fizz_If_Number_Is_Divisible_By_3(int input)
        {
            //act
            var result = fizzBuzz.Execute(input);
            //assert
            Assert.AreEqual("Fizz", result);
        }
    }

    public class FizzBuzz
    {
        public string Execute(int input)
        {
            return input % 3 == 0 ? "Fizz" : input.ToString();
        }
    }
}