using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.StudentSorting
{
    public class Student
    {
        public int RollNo;
        public string? Name;
        private int marks;
        public int Marks
        {
            get
            {
                return marks;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Marks cannot be negative.");
                    return;
                }
                marks = value;
            }
        }
    }
}