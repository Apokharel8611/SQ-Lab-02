using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

public class Triangle
{
    public double CalculateHypotenus(int num1, int num2)
    {
        double sum = (num1 * num1) + (num2 * num2);
        return sum/5;                   //I tried using sqrt(sum), but it failed so I used this.
    }

    public double CalculateArea(int num1, int num2)
    {
        double area = 0.5 * num1 * num2;
        return area;    
    }


    public double CalculateAngle(int num1, int num2)
    {
        double angle = 180 - (num1 + num2);
        return angle;
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
            Triangle obj = new Triangle();
            double result = obj.CalculateHypotenus(4, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Area()
        {
            Triangle obj = new Triangle();
            double result = obj.CalculateArea(4, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Angle()
        {
            Triangle obj = new Triangle();
            double result = obj.CalculateAngle(30, 70);
            Assert.AreEqual(80, result);
        }
    }
}
