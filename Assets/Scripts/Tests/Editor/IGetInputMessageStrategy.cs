namespace Tests.Editor
{
    public interface IGetInputMessageStrategy
    {
        string GetMessage(int input);
    }

    public class FizzStrategy : IGetInputMessageStrategy
    {
        public const int FizzNumber = 3;
        public const string FizzMessage = "Fizz";

        public string GetMessage(int input)
        {
            if (input % FizzNumber == 0 || input.ToString().Contains(FizzNumber.ToString())) {
                return FizzMessage;
            }

            return string.Empty;
        }
    }
    
    public class BuzzStrategy : IGetInputMessageStrategy
    {
        public const int BuzzNumber = 5;
        public const string BuzzMessage = "Buzz";

        public string GetMessage(int input)
        {
            if (input % BuzzNumber == 0 || input.ToString().Contains(BuzzNumber.ToString())) {
                return BuzzMessage;
            }

            return string.Empty;
        }
    }
    
    public class WhizzStrategy : IGetInputMessageStrategy
    {
        public const int SumForWhizz = 7;
        public const string WhizzMessage = "Whizz";

        public string GetMessage(int input)
        {
            if (SumInputCharactersValue(input.ToString()) == SumForWhizz) {
                return WhizzMessage;
            }
            
            return string.Empty;
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