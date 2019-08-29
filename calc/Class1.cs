using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calc
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double a, double b)
        {
            return Math.Pow(a,b);
        }
        public double Divide(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                throw new Exception();
            }

            return a / b;


        }

    }
}
