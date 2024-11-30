using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Class1
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
        public int Score(string a)
        {
            string [] textt = a.Split(' ');
            Console.WriteLine(textt.Length);
            return textt.Length;
        }
    }
}
