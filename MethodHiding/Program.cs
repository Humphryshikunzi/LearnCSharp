using System;
using System.Reflection.Metadata;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Learning about method hiding");
            Console.WriteLine();
             PartTimeEmployee pte = new PartTimeEmployee();
             pte.PrintName();

            // to execute whateve =r is in the base class, alternatively, create the instance of the class
            // using the options below
            Console.WriteLine();
            Console.WriteLine("Create instance using base class that refers to derrived class" +
                "Why, because the derivved class has all the functionality of the base class");
            Employee emp = new PartTimeEmployee();
            emp.PrintName();

            //alternative three
            Console.WriteLine();
             ((Employee)pte).PrintName();
        }
    }

    public class Employee
    {
        public string  FirstName { get; set; } 
        public  string  LastName { get; set; }
        public Employee()
        {
            FirstName = "Humphry";
            LastName = "Shikunzi";
        }

        public void PrintName()
        {
            Console.WriteLine("Parent class");
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        // if the PrintName method is created here just like in the base class, the base class
        // will be overriden
        // use the new keyword to remove errors
     
        public new void PrintName()
        {
            Console.WriteLine("This is the new class");

            //Use the base key word to execute the base class method
            base.PrintName();

        }

    }
    public class FullTimeEmployee : Employee
    {

    }


}
