using System;

namespace DelegateEvent{
    public delegate void eventExample();
    public class Example{
        public event eventExample eve;
        public void triggerEvent(){
            eve += () => Console.WriteLine("event example") ;
            eve();
        }
        // public void disp(){
        //     Console.WriteLine("event example");
        // }
    }
}