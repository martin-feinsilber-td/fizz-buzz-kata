namespace DefaultNamespace
{
    public class FizzRule : ISuffixRule
    {
        public string Suffix => "Fizz";

        public bool Check(int number)
        {
            return number % 3 == 0 || number.ToString().Contains('3');
        }
    }
}