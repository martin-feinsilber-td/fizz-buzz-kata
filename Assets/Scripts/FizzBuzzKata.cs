namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private const string FizzBuzz = "FizzBuzz";
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static string ConvertNumber(int number)
        {
            if (number.ToString().Contains('3')) {
                return Fizz;
            }

            if (number % 15 == 0) {
                return FizzBuzz;
            }

            if (number % 5 == 0) {
                return Buzz;
            }

            if (number % 3 == 0) {
                return Fizz;
            }

            return number.ToString();
        }
    }
}