public class FizzBuzz
{
    public string GetElement(int value)
    {
        var result = string.Empty;

        if (value % 3 == 0 || HasGivenDigitInIt(value, 3))
        {
            result += "Fizz";
        }

        if (value % 5 == 0 || HasGivenDigitInIt(value, 5))
        {
            result += "Buzz";
        }

        if (GetSumOfDigits(value) == 7)
        {
            result += "Whizz";
        }

        return result == string.Empty ? value.ToString() : result;
    }

    private bool HasGivenDigitInIt(int value, int digit)
    {
        while (value != 0)
        {
            if (value % 10 == digit)
            {
                return true;
            }

            value /= 10;
        }

        return false;
    }

    private int GetSumOfDigits(int value)
    {
        var sum = 0;

        while (value != 0)
        {
            sum += value % 10;
            value /= 10;
        }

        return sum;
    }
}