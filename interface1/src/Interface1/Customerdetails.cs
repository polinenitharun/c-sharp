using System;

namespace Interface1
{
    public class Customer : ICustomer,ICustomer1{
        void ICustomer.Details(){
            Console.WriteLine("Customer 0 details\n name:tharun,age=21");
        }
        void ICustomer1.Details(){
            Console.WriteLine("Customer 1 details\n name:harry potter,age=20");
        }
        public void Details(){
            Console.WriteLine("Customer 4 details\n name:harry ,age=25");
        }
    }
}