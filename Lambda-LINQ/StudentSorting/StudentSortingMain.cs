using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.StudentSorting
{
    public class StudentSortingMain
    {
        /*
         Sorting + Comparer + OOP
Q7: Student Sorting Without LINQ
Create a Student class:
RollNo
Name
Marks
Task:
Store students in a List<Student>.
Sort:
First by Marks (descending)
If tie → Name (ascending)
Print sorted list.
Use IComparer<Student> or lambda.
        */


        public static void ExecuteUsingComparer()
        {
            List<Student> ll = new List<Student>
            {
              new Student{RollNo = 101, Name = "Alice", Marks = 45},
              new Student{RollNo = 102, Name = "Mike", Marks = 57},
              new Student{RollNo = 103, Name = "Henry", Marks = 63},
              new Student{RollNo = 104, Name = "Steve", Marks = 57},
            };

            ll.Sort(new StudentComparer());

            foreach (var item in ll)
            {
                System.Console.WriteLine($"Roll: {item.RollNo} | Name: {item.Name} | Marks: {item.Marks}");
            }
        }

        public static void ExecuteUsingLambda()
        {
            List<Student> ll = new List<Student>
            {
              new Student{RollNo = 101, Name = "Alice", Marks = 45},
              new Student{RollNo = 102, Name = "Mike", Marks = 57},
              new Student{RollNo = 103, Name = "Henry", Marks = 63},
              new Student{RollNo = 104, Name = "Steve", Marks = 57},
            };

            // sort using Lambda
            ll.Sort((s1, s2) =>
            {
                int m = s2.Marks - s1.Marks;
                if (m != 0)
                {
                    return m;
                }
                return s1.Name.CompareTo(s2.Name);
            });

            foreach (var item in ll)
            {
                System.Console.WriteLine($"Roll: {item.RollNo} | Name: {item.Name} | Marks: {item.Marks}");
            }

        }
    }
}