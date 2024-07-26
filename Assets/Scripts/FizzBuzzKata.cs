namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static string ConvertNumber(int number)
        {
            var result = "";
            if (CheckForFizz(number)) {
                result += Fizz;
            }
            if (CheckForBuzz(number)) {
                result += Buzz;
            }
            return result.Length > 0 ? result : number.ToString();
        }

        private static bool CheckForFizz(int number)
        {
            return number.ToString().Contains('3') || number % 3 == 0;
        }

        private static bool CheckForBuzz(int number)
        {
            return number.ToString().Contains('5') || number % 5 == 0;
        }
    }
}