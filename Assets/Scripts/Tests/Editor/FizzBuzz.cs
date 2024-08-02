namespace Tests.Editor
{
    public class FizzBuzz
    {
        public const string FizzMessage = "Fizz";
        public const string BuzzMessage = "Buzz";
        public const string WhizzMessage = "Whizz";
        public const string FizzBuzzMessage = FizzMessage + BuzzMessage;
        public const string BuzzWhizzMessage = BuzzMessage + WhizzMessage;

        public const int FizzNumber = 3;
        public const int BuzzNumber = 5;
        public const int SumForWhizz = 7;
        
        public string Execute(int input)
        {
            var result = string.Empty;

            if (input % FizzNumber == 0 || input.ToString().Contains(FizzNumber.ToString())) {
                result += FizzMessage;
            }
            
            if (input % BuzzNumber == 0 || input.ToString().Contains(BuzzNumber.ToString())) {
                result += BuzzMessage;
            }
            
            if (SumInputCharactersValue(input.ToString()) == SumForWhizz) {
                result += WhizzMessage;
            }

            if (string.IsNullOrEmpty(result)) {
                return input.ToString();
            }
            
            return result;
        }

        private int SumInputCharactersValue(string input)
        {
            var result = 0;
            foreach (var character in input) {
                if (int.TryParse(character.ToString(), out var digit)) {
                    result += digit;
                }
            }
            return result;
        }
    }
}