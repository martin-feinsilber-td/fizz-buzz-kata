namespace DefaultNamespace
{
    public class BuzzRule : ISuffixRule
    {
        public string Suffix => "Buzz";

        public bool Check(int number)
        {
            return number % 5 == 0 || number.ToString().Contains('5');
        }
    }
}