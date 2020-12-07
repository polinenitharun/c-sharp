using System;

namespace GradeBook
{
  
   
    public class example
    {
        public int x=0;
        public example(int x, int y){
            int a=x+y;
            Console.WriteLine("In example Constructor " + a);
        }
        
        public void name(string name){
            Name=name;

        }
        public String Name{
            get;set;
        }
        public delegate string show(string message);
        public void dele(){
            show log=exam;
            var result=log("hello");
            Console.WriteLine(result);
        }
        string exam(string message){
             return message;
        }
    }
}
    