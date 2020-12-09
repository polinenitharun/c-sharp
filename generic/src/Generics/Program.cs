using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           Customer<object> x=new Customer<object>("tharun",37,180);
           Customer<object> y=new Customer<object>("gary",42,978);
           x.add1(x.Id,x);
           x.add1(y.Id,y);
           x.display();        
           Console.WriteLine(x.name + x.Id + x.price);
           Console.WriteLine(y.name + y.Id + y.price);
           //simple generic actions      
           gen<String> g=new gen<String>();
           g.Data="tharun";
           gen<Int32> t=new gen<Int32>();
           t.Data=32;
           t.example();
           g.add("tha");
           g.add("poll");
           g.display();
        } 
    }

}
        
        
    

