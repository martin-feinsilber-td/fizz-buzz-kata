using System.Text;
using UnityEngine;

public class FizzBuzzProgram : MonoBehaviour
{
    void Start()
    {
        var fizzBuzz = new FizzBuzz();
        var sb = new StringBuilder();
        
        for (int i = 1; i <= 100; i++)
        {
            var value = fizzBuzz.GetElement(i);
            sb.Append(value);
            sb.Append('\n');
        }
        
        Debug.Log(sb.ToString());
    }
}
