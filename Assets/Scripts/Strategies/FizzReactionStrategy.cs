public class FizzReactionStrategy : BaseNumberReactionStrategy
{
    public override string GetReaction(int value)
    {
        return value % 3 == 0 || HasGivenDigitInIt(value, 3) ? "Fizz" : "";
    }
}
