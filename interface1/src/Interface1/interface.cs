namespace Interface1
{
    interface ICustomer
    {
        void Details();
    }
    interface ICustomer1
    {
        void Details();
    }
    interface ICustomer2
    {
        void Details1();
    }
    interface ICustomer3 : ICustomer2
    {
        void Details2();
         
    }
    interface ICustomer4
    {
        void Details();
    }
}