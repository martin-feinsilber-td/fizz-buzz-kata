public class FizzBuzz
{
    private INumberReactionStrategy[] strategies =
    {
        new FizzReactionStrategy(),
        new BuzzReactionStrategy(),
        new WhizzReactionStrategy()
    };

    public string GetElement(int value)
    {
        var result = string.Empty;

        foreach (var reactionStrategy in strategies)
        {
            result += reactionStrategy.GetReaction(value);
        }

        return result == string.Empty ? value.ToString() : result;
    }
}