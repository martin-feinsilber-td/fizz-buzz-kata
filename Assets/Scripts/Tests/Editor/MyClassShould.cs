using System.Text;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor
{
    [TestFixture]
    public class MyClassShould
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup_FizzBuzz()
        {
            fizzBuzz = new FizzBuzz();
        }
        
        [TestCase(1)]
        [TestCase(2)]
        public void Return_Same_Number_When_Is_Not_Divisible(int input)
        {
            //act
            var value = fizzBuzz.Execute(input);
            //test
            Assert.AreEqual(input.ToString(), value);
        }
        
        [TestCase(3)]
        public void Return_Fizz_When_Is_Divisible_By_Three(int input)
        {
            //act
            var value = fizzBuzz.Execute(input);
            //test
            Assert.AreEqual("Fizz", value);
        }
        
        [TestCase(5)]
        public void Return_Buzz_When_Is_Divisible_By_Five(int input)
        {
            //act
            var value = fizzBuzz.Execute(input);
            //test
            Assert.AreEqual("Buzz", value);
        }
        
        [TestCase(15)]
        public void Return_FizzBuzz_When_Is_Divisible_By_Five_And_Three(int input)
        {
            //act
            var value = fizzBuzz.Execute(input);
            //test
            Assert.AreEqual("FizzBuzz", value);
        }

        
    }
}