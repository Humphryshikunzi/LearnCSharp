using System;

namespace Conditional_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // an empasisees here will be on the difference between using if else statement and if statement alone. Using if statement alone 
            // makes the program run slowly, why, because the program checks for every condition, even if the first condition is aleady true
            // The advantage of using if ele is that onece the first true condition is met, the program does not bother to check the rest of the
            // conditios
            // for instance program A would run fatser than program B as bellow

            
            int number = 20;


             //Program A
            // exits after finding the first condition is true. 
             System.Console.WriteLine("Program A");
            if(number == 20)
            {
                System.Console.WriteLine("The number is  20");
            }
           else if(number ==  30)
            {
                System.Console.WriteLine("The number is  30");
            }
           else if(number ==  40)
            {
                System.Console.WriteLine("The number is  40");
            }
            else if(number ==  50)
            {
                System.Console.WriteLine("The number is  50");
            }
            else
            {
                System.Console.WriteLine("The number is not defined");
            }


             // Program B
             // Condinues checking for the other Conditions although it already found the first condition ti be true
             System.Console.WriteLine("\n Program B");
            if(number == 20)
            {
                System.Console.WriteLine("The number is  20");
            }
            if(number ==  30)
            {
                System.Console.WriteLine("The number is  30");
            }
            if(number ==  40)
            {
                System.Console.WriteLine("The number is  40");
            }
            if(number ==  50)
            {
                System.Console.WriteLine("The number is  50");
            }
            else
            {
                System.Console.WriteLine("The number is not defined");
            }
        }
    }
}
