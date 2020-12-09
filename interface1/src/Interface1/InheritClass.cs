using System;

namespace Interface1
{
    public class Inherit : ICustomer3
    {
        public void Details1(){
            Console.WriteLine("Customer 2 details\n name:varun,age=23");
        }
        public void Details2(){
            Console.WriteLine("Customer 3 details\n name:gary,age=31");
        }
    }
}