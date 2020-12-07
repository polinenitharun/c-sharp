using System;
using System.IO;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          FileStream file=new FileStream("test.txt", FileMode.OpenOrCreate , FileAccess.ReadWrite);
          Rectangle r = new Rectangle(10, 7);
          double a = r.area();
          Console.WriteLine("Area: {0}",a);
          file.WriteByte((byte)a);
          file.Position=0;
          Console.Write(Convert.ToInt32(file.ReadByte()) + "\n");
          file.Close();
          var y=new inherit(2,3);
          Console.WriteLine(y.disp());
          y.name("tharun");
          y.dele();
        }
    }
}
