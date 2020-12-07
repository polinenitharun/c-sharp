 using System;
 
 namespace GradeBook
 {
    public interface Shape {
      int area();
    }
   
    class Rectangle:  Shape {
      private int length;
      private int width;
      
      public Rectangle( int a = 0, int b = 0) {
         length = a;
         width = b;
      }
      public int area () { 
         Console.WriteLine("Rectangle class area :");
         return (width * length); 
      }
    }
 }