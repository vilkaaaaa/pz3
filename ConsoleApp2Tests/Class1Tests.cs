using Xunit;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    public class Class1Tests
    {
        [Fact()]
        public void ChetnostTest()
        {
            Class1 calculator = new Class1();
            bool res = true;
            bool res1 = false;
            int i = 0;
            int j = -99;
            int k = 78;
            bool res3 = true;
            bool actualres3 = calculator.Chetnost(k);
            bool actualres1 = calculator.Chetnost(j);
            bool actualres = calculator.Chetnost(i);
            Xunit.Assert.Equal(res, actualres);
            Xunit.Assert.Equal(res1, actualres1);
            Xunit.Assert.Equal(res3, actualres3);
        }

        [Fact()]
        public void AddTest()
        {
           Class1 calculator = new Class1();
            int a = 2;
            int b = 3;
            int res = 5;
            int actualres = calculator.Add(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void SubstracktTest()
        {
            Class1 calculator = new Class1();
            int a = 85;
            int b = 19;
            int res = 66;
            int actualres = calculator.Substrackt(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void MultiplyTest()
        {
            Class1 calculator = new Class1();
            int a = 8;
            int b = 7;
            int res = 56;
            int actualres = calculator.Multiply(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void DivideTest()
        {
            Class1 calculator = new Class1();
            int a = 34;
            int b = 17;
            int res = 2;
            int actualres = calculator.Divide(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void ScoreTest()
        {
            Class1 calculator = new Class1();
            int i = 5;
            string a = "hello bro, i am friend";
            int res = calculator.Score(a);
            Xunit.Assert.Equal(i,res);
        }
    }
}