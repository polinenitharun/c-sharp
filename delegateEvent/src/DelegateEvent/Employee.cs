using System;
using System.Collections.Generic;

namespace DelegateEvent{
    delegate bool IsEligible(Employee example);
    class Employee
    {
        
        public int ID {get;set;}
        public string name {get;set;}
        public int Leaves {get;set;}
        public int Experience {get;set;}
        //reusable method based on the criteria for vacation(i.e vacation given based on leaves, experience etc)
        public static void Vacation(List<Employee> employee,IsEligible e){
            foreach(var emp in employee){
                if(e(emp)){
                    Console.WriteLine(emp.name + " eligible for vacation");
                }
            }
        }
    }
}