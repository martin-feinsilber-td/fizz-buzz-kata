namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string Whizz = "Whizz";

        public string ConvertNumber(int number)
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

        private bool WhizzCheck(int number)
        {
            var sum = 0;
            foreach (var digit in number.ToString()) {
                if (digit is >= '0' and <= '9') {
                    sum += digit - '0';
                }
            }
            return sum == 7;
        }

        private bool FizzCheck(int number)
        {
            return number.ToString().Contains('3') || number % 3 == 0;
        }

        private bool BuzzCheck(int number)
        {
            return number.ToString().Contains('5') || number % 5 == 0;
        }
    }
}