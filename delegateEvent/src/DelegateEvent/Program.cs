using System;
using System.Collections.Generic;

namespace DelegateEvent
{
    public delegate void multicast();
    class Program
    {
        static void Main(string[] args)
        {
            Example ev=new Example();
            ev.triggerEvent();
           

            //multicast delegates example
            multicast del =new multicast(employee1);
            multicast del1 =new multicast(employee3);
            del1();
            //multicast using single delegate for mutiple functions
            del += employee2;
            del();
            List<Employee> empList=new List<Employee>();
            
            Employee x=new Employee(){ID=100,name="tharun",Leaves=20,Experience=5};
            Employee y=new Employee(){ID=101,name="harry potter",Leaves=5,Experience=6};
            empList.Add(x);
            empList.Add(y);
            IsEligible EligibleForVacation=new IsEligible(Allot);
            Employee.Vacation(empList,Allot);

        }
        public static bool Allot(Employee e){
                 if(e.Leaves>10){
                     return true;
                 }
                 else{
                     return false;
                 }
        }
        public static void employee1(){
            Console.WriteLine("name : tharun\n age : 21");
        }
        public static void employee2(){
            Console.WriteLine("name : ajay\n age : 25");
        }
        public static void employee3(){
            Console.WriteLine("name : naresh\n age : 23");
        }
        
    }
}
