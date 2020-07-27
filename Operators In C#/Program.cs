using System;

namespace Operators_In_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numberOne = 10;
            int numberTwo = 20;

           // Checking the and and or operators in C#

            // this condtion is true only and only if all the conditios are true
            System.Console.WriteLine("Checking the && operation...");
            if (numberOne ==  10 && numberTwo == 20)
            {
                System.Console.WriteLine("Number one == {0} and number two =={1}", numberOne, numberTwo);
            }
            else
            {
                System.Console.WriteLine("The condition is not true");
            }

             if (numberOne ==  10 && numberTwo == 21)
            {
                System.Console.WriteLine("Number one == {0} and number two =={1}", numberOne, numberTwo);
            }
            else
            {
                System.Console.WriteLine("The condition is not true\n");
            }


             // this condtion is true if any of the conditions are true
             System.Console.WriteLine("Checking the || operation...");
            if (numberOne ==  10 || numberTwo == 20)
            {
                System.Console.WriteLine("Number one == {0} and number two =={1}", numberOne, numberTwo);
            }
            else
            {
                System.Console.WriteLine("The condition is not true");
            }

             if (numberOne ==  10 || numberTwo == 21)
            {
                System.Console.WriteLine("Number one == {0} and number two =={1}", numberOne, numberTwo);
            }
            else
            {
                System.Console.WriteLine("The condition is not true");
            }



            // Checking for the Ternary operator in C#
            // if the condition is true, the value on the left is taken, else the value on the right

            int myNumber = 40;

            bool checkNumber = myNumber == 41 ? true : false;

             System.Console.WriteLine(checkNumber);


             // The operators double ambersnad and double pie && and || respectively are colled short circuit operators
             // what they do is that when the first condion is met, they don't bothe checking the other conditions
             // this makes the programs run faster, as compared to single ambersand and single pie (& and |) respectively  that even if the
             // first condition that is right is already met, they go on to check all the conditions. Thsi makes the programs to run
             // slowly
        }
    }
}
