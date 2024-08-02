namespace DefaultNamespace
{
    public class WhizzRule : ISuffixRule
    {
        public string Suffix => "Whizz";

        public bool Check(int number)
        {
            var sum = 0;
            foreach (var digit in number.ToString()) {
                if (digit is >= '0' and <= '9') {
                    sum += digit - '0';
                }
            }
            return sum == 7;
        }
    }
}