public class BuzzReactionStrategy : BaseNumberReactionStrategy
{
    public override string GetReaction(int value)
    {
        return value % 5 == 0 || HasGivenDigitInIt(value, 5) ? "Buzz" : "";
    }
}
