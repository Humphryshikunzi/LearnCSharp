using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        delegate void SampleMethodsDelegate();
        delegate  int SampleMethodsDelegateWithReturn();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var employees = new List<Employee>()
            {
             new Employee(){Id = 1, Name = "Humphry", Experience = 3},
             new Employee(){Id = 2, Name = "Antonina", Experience = 4},
             new Employee(){Id = 1, Name = "Jackson", Experience = 5},
             new Employee(){Id = 2, Name = "Phostine", Experience = 1},
            };
            Employee.PromoteEmployee(employees, emp => emp.Experience >= 4);

            // Muliticast delegates
            var sampleDel = new SampleMethodsDelegate(MultiCastDelegatesDemo.Method1);
            sampleDel += MultiCastDelegatesDemo.Method2;
            sampleDel += MultiCastDelegatesDemo.Method3;
            sampleDel();
            // if at all I would want to unsubscribe from the above subscription, use -= signs

            var returnSampleDel = new SampleMethodsDelegateWithReturn(MultiCastDelegatesDemo.SampleMethodReturn10);
            returnSampleDel += MultiCastDelegatesDemo.SampleMethodReturn20;
            int numb = returnSampleDel();
            Console.WriteLine(numb);


            // if the out parameter is used, likewise, the out parameter is the one returned
            // delegates are used with the observe, publish subscribe pattern
        }
    }
    delegate bool IsPromotable(Employee emp);
    class Employee
    {
        public int  Id { get; set; }
        public  string  Name { get; set; }
        public   int  Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees, IsPromotable IsEligibleToPromote)
        {
            foreach (var  employee in  employees)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine($"{employee.Name} is eligible for promotion");
                }
            }
        }
    }

    class MultiCastDelegatesDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }


        // if the sample method is to return a value, the value assigned to the last chained delegate
        // is the one assigned
        public static int  SampleMethodReturn10()
        {
            return 10;
        }

        public static int SampleMethodReturn20()
        {
            return 20;
        }
    }

}
