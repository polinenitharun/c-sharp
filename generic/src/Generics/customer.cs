using System;
using System.Collections.Generic;
namespace Generics{
   class Customer<T> : customerClass<T>{   
        static int count=0;
        public String name;
        public int Id;
        public float price;
        public Customer(){  }
                
        public List<T> customers =new List<T>();
        public Dictionary<T,T> dictonaries= new Dictionary<T,T>();
        public Customer(String name , int Id, float price){
            this.name=name;
            this.Id=Id;
            this.price=price;
            count++;
        }

        public void add1(T b, T a){
           dictonaries.Add(b,a);
           customers.Add(a);
           
        }
        public void display(){
           // Customer<object> x;
         foreach (var dict in dictonaries){
               Console.WriteLine(dict.Key);
               //x=dict.Value;
               Console.WriteLine(dict.Value);
         }
        } 
    }
}
