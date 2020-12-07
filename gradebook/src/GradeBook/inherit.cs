using System;

namespace GradeBook
{
    public class inherit : example{
        
        public inherit(int a,int b) : base(a,b)
        {
            Console.WriteLine("In inherit Constructor");
            x=a+b;
        }
       public int disp(){
          return x;
       
       }
       
    }
}


