using System;

namespace ExtensionMethod{
    static class method{
        //passing class as parameter
        public static void example(this Program p){
            Console.WriteLine("example");
        }
        //passing the value as parameter
        public static string ConvertString(this string a){
            char[] x=a.ToCharArray();
            x[0]=char.IsUpper(x[0]) ? char.ToLower(x[0]) : char.ToUpper(x[0]);
            return new string(x);
        }
        public static int factorial(this int a){
            int x=1;
            while(a>0){
                x=x*a;
                a--;
            }
            return x;
        }
    }
}