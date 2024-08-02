using System.Collections.Generic;

namespace Tests.Editor
{
    public class FizzBuzz
    {
        private readonly List<IGetInputMessageStrategy> strategies;

        public FizzBuzz()
        {
            strategies = new List<IGetInputMessageStrategy> {
                new FizzStrategy(),
                new BuzzStrategy(),
                new WhizzStrategy(),
            };
        }

        public string Execute(int input)
        {
            var result = string.Empty;

            foreach (var strategy in strategies) {
                result += strategy.GetMessage(input);
            }

            return string.IsNullOrEmpty(result) ? input.ToString() : result;
        }
    }
}