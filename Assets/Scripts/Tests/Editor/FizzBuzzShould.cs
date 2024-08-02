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
        public void Return_Same_Number(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(input.ToString(), result);
        }
        
        [TestCase(3)]
        [TestCase(6)]
        public void Return_Fizz_If_Number_Is_Only_Divisible_By_3(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzStrategy.FizzMessage, result);
        }
        
        [TestCase(5)]
        [TestCase(50)]
        [TestCase(55)]
        public void Return_Buzz_If_Number_Is_Only_Divisible_By_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(BuzzStrategy.BuzzMessage, result);
        }
        
        [TestCase(15)]
        public void Return_FizzBuzz_If_Number_Is_Divisible_By_3_And_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzStrategy.FizzMessage + BuzzStrategy.BuzzMessage, result);
        }

        [TestCase(13)]
        public void Return_Fizz_If_Number_Contains_3(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzStrategy.FizzMessage, result);
        }

        [TestCase(5)]
        public void Return_Buzz_If_Number_Contains_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(BuzzStrategy.BuzzMessage, result);
        }

        [TestCase(35)]
        [TestCase(53)]
        public void Return_FizzBuzz_If_Number_Contains_5_And_3(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(FizzStrategy.FizzMessage + BuzzStrategy.BuzzMessage, result);
        }

        [TestCase(61)]
        public void Return_Whizz_If_Sum_Of_Digits_Equals_7(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(WhizzStrategy.WhizzMessage, result);
        }
        
        [TestCase(52)]
        public void Return_BuzzWhizz_If_Sum_Of_Digits_Equals_7_And_Contains_5(int input)
        {
            var result = fizzBuzz.Execute(input);
            Assert.AreEqual(BuzzStrategy.BuzzMessage + WhizzStrategy.WhizzMessage, result);
        }
    }
}