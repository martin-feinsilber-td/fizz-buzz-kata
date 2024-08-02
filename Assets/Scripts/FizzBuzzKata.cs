using System.Collections.Generic;

namespace DefaultNamespace
{
    public class FizzBuzzKata
    {
        private readonly IEnumerable<ISuffixRule> suffixRules = new ISuffixRule[] {
            new FizzRule(),
            new BuzzRule(),
            new WhizzRule(),
        };

        public string ConvertNumber(int number)
        {
            var result = "";
            foreach (var rule in suffixRules) {
                if (rule.Check(number)) {
                    result += rule.Suffix;
                }
            }
            return result.Length > 0 ? result : number.ToString();
        }
    }
}