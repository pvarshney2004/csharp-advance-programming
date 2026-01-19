using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lambda.StudentSorting
{
    public class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            int m = s2.Marks - s1.Marks; // sort by marks(descending)
            if (m != 0)
            {
                return m;
            }
            else
            {
                return string.Compare(s1.Name, s2.Name); // sort by name(ascending)
            }
        }
    }
}