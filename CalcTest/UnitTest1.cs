using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        Calc Calc = new Calc();

        [TestMethod]
        public void TestDotClickHandler()
        {
            Assert.AreEqual("0.", Calc.DotClickHandler("0"));
            Assert.AreEqual("10.", Calc.DotClickHandler("10"));
            Assert.AreEqual("0.1", Calc.DotClickHandler("0.1"));
        }

        [TestMethod]
        public void TestSignClickHandler()
        {
            Assert.AreEqual("0", Calc.SignClickHandler("0"));
            Assert.AreEqual("-10", Calc.SignClickHandler("10"));
            Assert.AreEqual("0.1", Calc.SignClickHandler("-0.1"));
        }

        [TestMethod]
        public void TestNumberClickHandler()
        {
            Assert.AreEqual("0", Calc.NumberClickHandler("0", "0"));
            Assert.AreEqual("-10", Calc.NumberClickHandler("-1", "0"));
            Assert.AreEqual("10", Calc.NumberClickHandler("1", "0"));
            Assert.AreEqual("0.10", Calc.NumberClickHandler("0.1", "0"));
        }

        [TestMethod]
        public void TestEqual()
        {
            string screenText = "0";
            screenText = Calc.OperationClickHandler("0", "=");
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("11", "+");
            screenText = Calc.OperationClickHandler("11", "=");
            screenText = Calc.OperationClickHandler("22", "=");
            Assert.AreEqual("22", screenText);
            screenText = Calc.OperationClickHandler("22", "=");
            Assert.AreEqual("22", screenText);
            screenText = Calc.OperationClickHandler("11", "+");
            screenText = Calc.OperationClickHandler("11", "=");
            screenText = Calc.OperationClickHandler("22", "=");
            Assert.AreEqual("22", screenText);
        }

        [TestMethod]
        public void TestOperationAdd()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("11", "+");
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("22", screenText);
        }

        [TestMethod]
        public void TestOperationSub()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("11", "-");
            screenText = Calc.OperationClickHandler("1", "=");
            Assert.AreEqual("10", screenText);
        }

        [TestMethod]
        public void TestOperationMulti()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("11", "*");
            screenText = Calc.OperationClickHandler("5", "=");
            Assert.AreEqual("55", screenText);
        }

        [TestMethod]
        public void TestOperationDiv()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("22", "/");
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("2", screenText);
        }

        [TestMethod]
        public void TestAllOperations()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("11", "+");
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("22", screenText);

            screenText = Calc.OperationClickHandler(screenText, "-");
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("11", screenText);

            screenText = Calc.OperationClickHandler(screenText, "*");
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("5", "=");
            Assert.AreEqual("55", screenText);

            screenText = Calc.OperationClickHandler(screenText, "/");
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("5", "=");
            Assert.AreEqual("11", screenText);
        }

        [TestMethod]
        public void TestClearClickHandler()
        {
            string screenText = "";
            screenText = Calc.OperationClickHandler("22", "/");
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("2", screenText);
            screenText = Calc.ClearClickHandler();
            Assert.AreEqual("0", screenText);
            screenText = Calc.OperationClickHandler("22", "/");
            screenText = Calc.OperationClickHandler("11", "=");
            Assert.AreEqual("2", screenText);
        }
    }
}
