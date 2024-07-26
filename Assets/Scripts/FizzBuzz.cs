public class FizzBuzz
{
    public string GetElement(int value)
    {
        var result = string.Empty;
            
        if (value % 3 == 0)
        {
            result += "Fizz";
        }
            
        if (value % 5 == 0)
        {
            result += "Buzz";
        }

        return result == string.Empty ? value.ToString() : result;
    }
}