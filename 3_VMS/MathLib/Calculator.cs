using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Calculator
    {
        private int result;
        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public void Add(int op1, int op2)
        {
            result = op1 + (++op2);
        }

        public void Sub(int op1, int op2)
        {
            result = op1 - op2;
        }


        public void Mult(int op1, int op2)
        {
            result = op1 * op2;
        }


        public void Div(int op1, int op2)
        {
            result = op1 / op2;
        }
    }
}

