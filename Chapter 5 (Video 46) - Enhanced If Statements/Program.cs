using System;

namespace Chapter_5__Video_46____Enhanced_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
             /* Shortcuts for if statements
              * 
              * The example syntax:
              *  
              *  condition ? first_expression : second_expression;
              *  
              *  condition has to be either true or false
              *  The conditional operator is right - associative.
              *  The expression a ? b: c? d : e
              *  is evaluated as a ? b : (c ? d : e),
              *  not as (a? b : c) ? d: e.
              *  The conditional operator cannot be overloaded.
              * 
              * */


            int temperature = -5;
            string stateOfMatter;

            //Long Version

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            temperature += 30;

            //Short Version
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is {0}", stateOfMatter);

            //challenge
            temperature += 100;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of Matter is {0}", stateOfMatter);


            Console.ReadKey();
        }
    }
}
