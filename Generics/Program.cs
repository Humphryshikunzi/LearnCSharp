using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // tests for generics
            // generics avoid using the object class, which otherwise is 
            // legal in C#, eventhough its causes degradation due to boxing 
            // and unboxing that is done alot 
            Console.WriteLine("Hello World!");
            Console.WriteLine(GenericDemo<int>.CompareTwoValues(4, 7));
            Console.WriteLine(GenericDemo<int>.CompareTwoValues(8, 8));
            

            // have noticed that the equals method for strings is case sensitive
            Console.WriteLine(GenericDemo<string>.CompareTwoValues("Hello", "hello"));
        }
    }

    class GenericDemo<T>
    {
        public static  bool CompareTwoValues(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
