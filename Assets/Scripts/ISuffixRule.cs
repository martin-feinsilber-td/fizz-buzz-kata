namespace DefaultNamespace
{
    public interface ISuffixRule
    {
        string Suffix { get; }
        bool Check(int number);
    }
}