using System.Collections.Generic;
using Functional.Maybe;
using UnityEngine;

namespace DefaultNamespace
{
    public class MyClass
    {
        public string Name;
        public Maybe<MySecondClass> Other;

        public MyClass(string name, MySecondClass other)
        {
            Other = other.ToMaybe();
        }
    }

    public class MySecondClass
    {
        
    }
    
    
    
    public class MaybeExample
    {
        private MyClass asd = null;
        
        public void Init()
        {

           

            // asd.ToMaybe().IsSomething()

            asd.ToMaybe()
                .Do(x => Debug.Log(""));

            // if (asd != null)
            // {
            //     Debug.Log("")
            // }
            
            Maybe<int> myVar = Maybe<int>.Nothing;

            myVar = 1.ToMaybe();
            // if (myobo != null)
            // {
            //     Debug.Log() 
            // }
            // else
            // {
            //     
            // }
            
            // myExistingString
            //     .Do(Debug.Log)
            //     .DoWhenAbsent(() => {});


        }
    }
}