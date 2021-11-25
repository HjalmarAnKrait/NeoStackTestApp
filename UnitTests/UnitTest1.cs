using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeoStackTestApp;
using NeoStackTestApp.Models;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        

        [TestMethod]
        [DataRow(40, 2, 4)]
        [DataRow(10, 2, 1)]
        [DataRow(1, 1, 1)]
        [DataRow(4, 1, 4)]
        [DataRow(0, 0, 0)]
        public void CalcCTest(double expected, double degree, double c)
        {
            double actual = Calculator.CalcC(degree, c);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [DataRow(5, 5, 1)]
        [DataRow(5, 5, -32)]
        [DataRow(153, 153, 1)]
        [DataRow(1, 1, 1)]
        [DataRow(0, -143, 1)]
        public void GetCListTest(int expected, int size, double degree)
        {
            int actual = Calculator.GetCList(size, degree).Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(1, 1, 1, 1, 1, 1, 3)]
        [DataRow(1, 1, 1, 1, 1, -3, 3)]
        [DataRow(1, 1, 1, 1, 1, 0, 3)]
        [DataRow(2, 2, 3, 1, 1, 2, 34)]
        [DataRow(12, 0, 4, 10, 2, 2, 1240)]
        [DataRow(-43, -43, 1, 2, 0, 1, -128)]
        public void CalculateFunctionTest(double a, double b, double c, double x, double y, double degree, double expected)
        {
            FunctionModel functionModel = new FunctionModel(degree, c, a, b);
            Debug.WriteLine($"{x} {y} {a} {b} {c} ");
            FunctionArgsModel functionArgsModel = new FunctionArgsModel(x, y, functionModel);
            Debug.WriteLine($"{functionArgsModel.X} {functionArgsModel.Y} {functionArgsModel.F}");

            double actual = functionArgsModel.F;
            Assert.AreEqual(expected,  actual);
        }
    }
}
