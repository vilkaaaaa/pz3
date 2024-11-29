using NUnit.Framework;
using pz3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        [Test()]
        public void ChetnostTest()
        {
            Calculator calculator = new Calculator();
            int i = 0;
            //int j = 98;
            //int k = 77;
            string res1 = "четное";
            //string res2 = "четное";
            //string res3 = "нечетное";
            string actualres1 = calculator.Chetnost(i);
            //string actualres2 = calculator.Chetnost(98);
            //string actualres3 = calculator.Chetnost(77);
            Assert.Equals(res1, actualres1);
            //Assert.Equals(res2, actualres2);
            //Assert.Equals(res3, actualres3);
        }
    }
}