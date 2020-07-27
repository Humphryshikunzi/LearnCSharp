using System;

namespace Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // There are three different types of Comments in C#
            // Single line commnt, the two forward slashes /
            // multiple line comments /* ... */
            // xaml documentation comemnts. In code, sometimes when you hover your mouse over a class, you see information about what  that 
            // class can do. demo is bellow

            var class = new XamlDocumentationComments();
        }
    }

    public class XamlDocumentationComments
    {
         /// <Summary>
        /// This class is for test
        /// <Summary>
      public int  Age { get; set; }           
    }
}
