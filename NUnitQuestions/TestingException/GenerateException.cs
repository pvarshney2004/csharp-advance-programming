using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingException
{
    public class GenerateException
    {
        // method to throw exception
        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}