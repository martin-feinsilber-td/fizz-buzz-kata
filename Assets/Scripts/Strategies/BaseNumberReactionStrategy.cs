public abstract class BaseNumberReactionStrategy : INumberReactionStrategy
{
    public abstract string GetReaction(int value);

    protected bool HasGivenDigitInIt(int value, int digit)
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

    protected int GetSumOfDigits(int value)
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
