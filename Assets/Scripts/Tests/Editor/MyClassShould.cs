using NUnit.Framework;
namespace Tests.Editor
{
    [TestFixture]
    public class MyClassShould
    {
        [TestCase(1)]
        [TestCase(2)]
        public void Return_Same_Number_When_Is_Not_Divisible(int input)
        {
            //arrange
            NumberConversion numberConversion = new NumberConversion();
            //act
            var value = numberConversion.Execute(input);
            //test
            Assert.AreEqual(input.ToString(), value);
        }
        
        [TestCase(3)]
        public void Return_Fizz_When_Is_Divisible_By_Three(int input)
        {
            //arrange
            NumberConversion numberConversion = new NumberConversion();
            //act
            var value = numberConversion.Execute(input);
            //test
            Assert.AreEqual("Fizz", value);
        }
        
        [TestCase(5)]
        public void Return_Buzz_When_Is_Divisible_By_Five(int input)
        {
            //arrange
            NumberConversion numberConversion = new NumberConversion();
            //act
            var value = numberConversion.Execute(input);
            //test
            Assert.AreEqual("Buzz", value);
        }
        
        [TestCase(15)]
        public void Return_FizzBuzz_When_Is_Divisible_By_Five_And_Three(int input)
        {
            //arrange
            NumberConversion numberConversion = new NumberConversion();
            //act
            var value = numberConversion.Execute(input);
            //test
            Assert.AreEqual("FizzBuzz", value);
        }
    }

    public class NumberConversion
    {
        public object Execute(int i)
        {
            if (i % 15 == 0) {
                return "FizzBuzz";
            }
            else if (i % 3 == 0) {
                return "Fizz";
            }
            else if (i % 5 == 0) {
                return "Buzz";
            }
            
            return i.ToString();
        }
    }
}