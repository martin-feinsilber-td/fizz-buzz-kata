using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class FizzBuzz
{
    public const string Fizz = "Fizz";
    public const string Buzz = "Buzz";
    public const string Whizz = "Whizz";

    public object Execute(int i)
    {
        StringBuilder result = new StringBuilder();
        
        if (i % 3 == 0 || i.ToString().Contains('3')) {
            result.Append(Fizz);
        }
        
        if (i % 5 == 0 || i.ToString().Contains('5')) {
            result.Append(Buzz);
        }

        if (SumOfDigits(i) == 7) {
            result.Append(Whizz);
        }
        
        return result.Length == 0 ? i.ToString() : result.ToString();
    }

    public int SumOfDigits(int number)
    {
        var result = 0;
        while (number > 0) {
            result += number % 10;
            number /= 10;
        }
        return result;
    }
}
