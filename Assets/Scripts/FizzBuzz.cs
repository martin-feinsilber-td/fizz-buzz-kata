using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz
{
    public object Execute(int i)
    {
        bool fizz = false;
        bool buzz = false;
        
        if (i.ToString().Contains('3')) {
            fizz = true;
        }
        
        if (i.ToString().Contains('5')) {
            buzz = true;
        }
        
        if (i % 3 == 0) {
            fizz = true;
        }
        
        if (i % 5 == 0) {
            buzz = true;
        }

        if (fizz && buzz) {
            return "FizzBuzz";
        }
        else if (fizz) {
            return "Fizz";
        }
        else if (buzz) {
            return "Buzz";
        }
        else {
            return i.ToString();
        }
    }
}
