using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using NeoStackTestApp;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {

        

        [TestMethod]
        public void CalcCTest()
        {  
            Assert.AreEqual(40, Calculator.CalcC(2, 4));
            Assert.AreEqual(10, Calculator.CalcC(2, 1));
            Assert.AreEqual(1, Calculator.CalcC(1, 1));
            Assert.AreEqual(4, Calculator.CalcC(1, 4));
            Assert.AreEqual(0, Calculator.CalcC(0, 0));
        }

        [TestMethod]
        public void GetCListTest()
        {
            Assert.AreEqual(5, Calculator.GetCList(5, 1).Count);
            Assert.AreEqual(153, Calculator.GetCList(153, 1).Count);
            Assert.AreEqual(0, Calculator.GetCList(0, 1).Count);
            Assert.AreEqual(0, Calculator.GetCList(-143, 1).Count);
        }

        [TestMethod]
        public void CalculateFunctionTest()
        {
            FunctionCalcModel functionCalcModelZero = new FunctionCalcModel();
            FunctionCalcModel functionCalcModel = new FunctionCalcModel(1,1,1,1,1,1,2);

            Assert.AreEqual(0.0, Calculator.CalculateFunction(0.0, functionCalcModelZero));
            Assert.AreEqual(12.0, Calculator.CalculateFunction(functionCalcModel));
        }
    }
}
