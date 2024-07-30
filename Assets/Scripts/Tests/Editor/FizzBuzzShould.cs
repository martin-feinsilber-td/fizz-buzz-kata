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
        [TestCase(6)]
        public void Return_Fizz_If_Number_Is_Only_Divisible_By_3(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzBuzz.FizzMessage, result);
        }
        
        [TestCase(5)]
        [TestCase(50)]
        [TestCase(55)]
        public void Return_Buzz_If_Number_Is_Only_Divisible_By_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzBuzz.BuzzMessage, result);
        }
        
        [TestCase(15)]
        public void Return_FizzBuzz_If_Number_Is_Divisible_By_3_And_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzBuzz.FizzBuzzMessage, result);
        }
    }

    public class FizzBuzz
    {
        public const string FizzMessage = "Fizz";
        public const string BuzzMessage = "Buzz";
        public const string FizzBuzzMessage = FizzMessage + BuzzMessage;
        
        public string Execute(int input)
        {
            if (input % 3 == 0 && input % 5 == 0) {
                return FizzBuzzMessage;
            }
            
            if (input % 3 == 0) {
                return FizzMessage;
            }
            
            if (input % 5 == 0) {
                return BuzzMessage;
            }

            return input.ToString();
        }
    }
}