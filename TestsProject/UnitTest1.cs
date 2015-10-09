using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestsProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOfLibraryProject()
        {
            //Arrange
            //instansierade class1 i libraryprojektet med en sut-variabel (standard variabel, System Under Test)
            //skickar med två siffror
            Class1 sut = new Class1();
            int i1 = 2;
            int i2 = 3;
            //Act
            sut.add(i1, i2);
            //Assert
            Assert.AreEqual(5, sut.result);
            //Assert.Fail();
        }
    }
}
