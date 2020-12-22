using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string s="tharun";
            int i=5;
            List<int> Numbers=new List<int>{1,3,2,4,5,9,8,6,7,10};

            Program program=new Program();
            program.example();

            string result=s.ConvertString();
            Console.WriteLine(result);

            Console.WriteLine("even numbers");
            IEnumerable<int> even=Enumerable.Where(Numbers,n => n %2==0);
            foreach(int num in even){
                Console.WriteLine(num +"\n");
            }

            Console.WriteLine("sorting numbers");
            IEnumerable<int> sort=Numbers.OrderBy(n => n);
            foreach(int num in sort){
                Console.WriteLine(num + "\n");
            }

            Console.WriteLine("Factorial of" + i);
            Console.WriteLine(i.factorial()); 
        }
    }
}
