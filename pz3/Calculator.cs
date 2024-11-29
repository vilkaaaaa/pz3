using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class Calculator
    {
        public bool Chetnost(int i)
        {
           return i % 2 == 0;
           
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substrackt(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
