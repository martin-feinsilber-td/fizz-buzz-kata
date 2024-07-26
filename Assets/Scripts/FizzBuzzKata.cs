namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Whizz = "Whizz";

        public static string ConvertNumber(int number)
        {
            var result = "";
            if (FizzCheck(number)) {
                result += Fizz;
            }
            if (BuzzCheck(number)) {
                result += Buzz;
            }
            if (WhizzCheck(number)) {
                result += Whizz;
            }
            return result.Length > 0 ? result : number.ToString();
        }

        private static bool WhizzCheck(int number)
        {
            var sum = 0;
            foreach (var digit in number.ToString()) {
                if (digit is >= '0' and <= '9') {
                    sum += int.Parse(digit.ToString());
                }
            }
            return sum == 7;
        }

        private static bool FizzCheck(int number)
        {
            return number.ToString().Contains('3') || number % 3 == 0;
        }

        private static bool BuzzCheck(int number)
        {
            return number.ToString().Contains('5') || number % 5 == 0;
        }
    }
}