using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test1;
using TestEkzMDK0202;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 fr = new Form1();
            fr.NewMethod(1, 12345);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Form1 fr = new Form1();
            fr.NewMethod(1, -1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Form1 fr = new Form1();
            fr.NewMethod(1, 2);
        }
    }
}
