namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        public static string ConvertNumber(int number)
        {
            var result = "";
            if (number.ToString().Contains('3') || number % 3 == 0) {
                result += Fizz;
            }
            if (number.ToString().Contains('5') || number % 5 == 0) {
                result += Buzz;
            }
            return result.Length > 0 ? result : number.ToString();
        }
    }
}