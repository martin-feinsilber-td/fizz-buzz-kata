using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz
{
    public object Execute(int i)
    {
        if (i % 15 == 0) {
            return "FizzBuzz";
        }
        else if (i % 3 == 0) {
            return "Fizz";
        }
        else if (i % 5 == 0) {
            return "Buzz";
        }
            
        return i.ToString();
    }
}
