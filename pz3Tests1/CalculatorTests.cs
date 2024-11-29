using Xunit;
using pz3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3.Tests
{
    public class CalculatorTests
    {
        [Fact()]
        public void ChetnostTest()
        {
            Calculator calculator = new Calculator();
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
            Calculator calculator = new Calculator();
            int a = 2;
            int b = 3;
            int res = 5;
            int actualres = calculator.Add(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

        [Fact()]
        public void SubstracktTest()
        {
            Calculator calculator = new Calculator();
            int a = 85;
            int b = 19;
            int res = 66;
            int actualres = calculator.Substrackt(a, b);
            Xunit.Assert.Equal(res, actualres);
        }

            [Fact()]
        public void MultiplyTest()
        {
                Calculator calculator = new Calculator();
                int a = 8;
                int b = 7;
                int res = 56;
                int actualres = calculator.Multiply(a, b);
                Xunit.Assert.Equal(res, actualres);
            }

        [Fact()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            int a = 34;
            int b = 17;
            int res = 2;
            int actualres = calculator.Divide(a, b);
            Xunit.Assert.Equal(res, actualres);
        }
    }
}