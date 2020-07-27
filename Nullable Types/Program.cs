using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Nullable types was introduced by Microsoft for some conditions, for instance imagine collecting data from a User in a form
            // where you are required to fill the gender where its optional, the user could fill in male, female or ignore

            // example 1
            bool? isMale = null;
            if (isMale == true)
            {
                System.Console.WriteLine("The user is Male");
            }
            else if(isMale == false)
            {
                System.Console.WriteLine("The user is Female");
            }
            else 
              {
               System.Console.WriteLine("The user did not specify gender");
            }

            //example two
            // it uses the Advantage of Null Coalesce operator to initialize the value to Zero incase the value is null
            int? numberOfItemsOnCounter = null;
            int totalItemsOnCounter = numberOfItemsOnCounter ?? 0;
            System.Console.WriteLine("The total number of items in the Counter is {0}", totalItemsOnCounter);

            //again, take not of the int.value, its true if the value has been assigned and false otherwise
            // the code did not run as expected. will recheck
            bool? areItemsThere  =   null;
            if(areItemsThere.Value)
            {
                System.Console.WriteLine("There are items : {0}", numberOfItemsOnCounter);
            }
            else if(!areItemsThere.Value)
            {
                System.Console.WriteLine("No items are there");
            }
            else
            {
                System.Console.WriteLine("No specification for item count");
            }

        }
    }
}
