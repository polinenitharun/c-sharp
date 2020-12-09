using System;

namespace Interface1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer x=new Customer();
            //default interface implementation
             x.Details();
            //explicit interfaces implementation
            ((ICustomer)x).Details();
            //parent class reference variable to child class object
            ICustomer2 z=new Inherit();
            ICustomer3 y=new Inherit();
            y.Details2();
            z.Details1();
        }
    }
}
