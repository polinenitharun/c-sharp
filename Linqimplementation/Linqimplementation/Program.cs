using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqimplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            linqExamples fun = new linqExamples();
            var num=fun.disp1();

            foreach(var n in num)
            {
                Console.WriteLine(n + "\n");
            }
            List<Student> stu = new List<Student>
            {
                new Student()
                {
                    student_Id=2,
                    student_name = "tharun",
                    student_marks=48
                },
                new Student()
                {
                    student_Id=1,
                    student_name = "arun",
                    student_marks=34
                },
                new Student()
                {
                    student_Id=4,
                    student_name = "akhil",
                    student_marks=40
                },
                new Student()
                {
                    student_Id=3,
                    student_name = "harry",
                    student_marks=50
                },
                 new Student()
                {
                    student_Id=5,
                    student_name = "harry potter",
                    student_marks=25
                }
            };
            List<StudentDetails> st = new List<StudentDetails>
            {
                new StudentDetails()
                {
                    student_Id=5,
                    student_age=22,
                    student_year = "2nd year",
                    student_percentage=55
                },
                 new StudentDetails()
                {
                    student_Id=3,
                    student_age=22,
                    student_year = "2nd year",
                    student_percentage=55
                },
                  new StudentDetails()
                {
                    student_Id=4,
                    student_age=22,
                    student_year = "2nd year",
                    student_percentage=55
                },
                   new StudentDetails()
                {
                    student_Id=1,
                    student_age=22,
                    student_year = "2nd year",
                    student_percentage=55
                },
                new StudentDetails()
                {
                    student_Id=2,
                    student_age=21,
                    student_year = "1st year",
                    student_percentage=75
                }
            };
            Console.WriteLine("joining two lists");
            var query = stu.Join(st,
                c => c.student_Id,
                ct => ct.student_Id,

                (c, ct) => new
                {
                    Name = c.student_name + " " + ct.student_age
                });
            foreach(var x in query)
            {
                Console.WriteLine(x.Name);
            }

            Console.WriteLine("using query syntax");
            var result = from s in stu
                         where s.student_marks > 40
                         select s;
           
            foreach(var Stud in result){
                Console.WriteLine(Stud.student_Id + " " + Stud.student_marks + " " + Stud.student_name);
            }

            Console.WriteLine("using method syntax");
            var result1 = stu.Where(s => s.student_marks < 40);
            foreach (var Stud in result1)
            {
                Console.WriteLine(Stud.student_Id + " " + Stud.student_marks + " " + Stud.student_name);
            }
            var res = stu.FirstOrDefault(s => s.student_marks > 40);
            Console.WriteLine(res.student_Id + " " + res.student_marks + " " + res.student_name);
            Console.WriteLine("sorting in descending order");
            var sol1 = stu.OrderByDescending(c => c.student_name);
            foreach (var order in sol1)
            {
                Console.WriteLine(order.student_Id + " " + order.student_marks + " " + order.student_name);
            }
            Console.WriteLine("Sorting in ascending order");
            var sol2 = sol1.Reverse();
            foreach (var order in sol2)
            {
                Console.WriteLine(order.student_Id + " " + order.student_marks + " " + order.student_name);
            }
        }
    }
}
