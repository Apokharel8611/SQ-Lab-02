using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public class Hypotenus
{
    public int CalculateHypotenus(int num1, int num2)
    {
        return 0;
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
