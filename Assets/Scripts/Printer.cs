using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Printer : MonoBehaviour
{
    private const int startRange = 1;
    private const int endRange = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        StringBuilder result = new StringBuilder();
            
        for (int i = startRange; i <= endRange; i++) {
            result.AppendLine(fizzBuzz.Execute(i).ToString());
        }
            
        Debug.Log(result.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
