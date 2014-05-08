using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalculatorv1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow mw = new MainWindow();
            //tes tambah
            Assert.AreEqual(2, mw.tambah(1,1.0));
            //tes kurang
            Assert.AreEqual(0, mw.kurang(0.99,0.99));
            //tes kali
            Assert.AreEqual(1, mw.kali(1.0, 1.0));
            //tes bagi
            Assert.AreEqual(1, mw.bagi(0.9909090, 0.9909090));
            Assert.AreEqual(double.PositiveInfinity, mw.bagi(9, 0));
            Assert.AreEqual(double.NegativeInfinity, mw.bagi(-9, 0));
            Assert.AreEqual(-1, mw.bagi(-9, 9));

        }


    }
}
