using System;

namespace RefKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = 78;
            CheckRef(ref number);
            System.Console.WriteLine("The number after passing it through a ref method is {0}", number);
         
           
        }

        static int CheckRef(ref int number)
        {
            number += 10;
            return number;
        }
    }
}