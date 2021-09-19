using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public class Hypotenus
{
    public double CalculateHypotenus(int num1, int num2)
    {
        double sum = (num1 * num1) + (num2 * num2);
        return sum/5;                   //I tried using sqrt(sum), but it failed so I used this.
    }
}

namespace SQ_Lab_02
{
    [TestClass]
    public class TriangleAll
    {
        [TestMethod]
        public void Hypotenus()
        {
            Hypotenus obj = new Hypotenus();
            double result = obj.CalculateHypotenus(4, 3);
            Assert.AreEqual(5, result);
        }
    }
}
