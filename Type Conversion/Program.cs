using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           // try a value we are sure it would be converted
            int number = 0;
            bool checConvertNumber = int.TryParse("100", out number);
            System.Console.WriteLine("The conversion was succesful: {0} and the value is {1}\n", checConvertNumber, number);


            // try a value that would raise exeptions
            int number2 = 0;
            bool checConvertNumber2 = int.TryParse("100TM", out number2);
            System.Console.WriteLine("The conversion failed: {0} and the value is {1}", checConvertNumber2, number2);


            //to convert from string to any datatype, use the Parse method like int.Parse("string to convert")

        }
    }
}
