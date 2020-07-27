using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // arrays are used for storing more than one value of the SAME datatype
            // arrays are strongly typed, meaning data can only be of the same datatype, you can not store integers  and strings at the
            // in the same array
            // arrrays are majorly advantagious because of the limited number of elements, no more elements can be stored more than the 
            // length of the array
            int[] numbers = new int[3];
            numbers[0] = 52;
            numbers[1] = 4;
            numbers[2] = 14;
            System.Console.WriteLine("Number at index 1  is {0}", numbers[1]);
        }
    }
}
