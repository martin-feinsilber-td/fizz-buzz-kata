public class WhizzReactionStrategy  : BaseNumberReactionStrategy
{
    public override string GetReaction(int value)
    {
        return GetSumOfDigits(value) == 7 ? "Whizz" : "";
    }
}
