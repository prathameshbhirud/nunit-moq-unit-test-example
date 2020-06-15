using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqClassLibrary;

namespace MoqUnitTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<CheckEmployee> chk = new Mock<CheckEmployee>();
            chk.Setup(x => x.checkEmp()).Returns(true);

            ProcessEmployee peObj = new ProcessEmployee();
            Assert.AreEqual(peObj.insertEmployee(chk.Object), true);

        }
    }
}
