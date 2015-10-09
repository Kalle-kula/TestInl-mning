using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestsProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //assert
            Class2 sut = new Class2();
            int i1 = 4;
            int i2 = 2;
            //Act
            sut.greaterNumber(i1, i2);
            //Assert
            Assert.IsTrue(sut.result);
        }
    }
}
