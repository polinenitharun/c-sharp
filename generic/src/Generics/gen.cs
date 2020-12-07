using System;
using System.Collections.Generic;

namespace Generics
{
    //generic class
    class gen<T>
    {
        static int count=0;
        public T Data { get; set; }
        public T[] arr = new T[4];
        
        public void example(){
            
            Console.WriteLine(Data);
        }
        //generic method arguments
        public void add(T num){
            arr[count]=num;
            count++;
        }
        public void display(){
            for(int i=0;i<arr.Length;i++)
                Console.WriteLine(arr[i]);
       }
        
   }
}