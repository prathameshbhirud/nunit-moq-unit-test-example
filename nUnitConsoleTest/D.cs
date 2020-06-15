using NUnit.Framework;
using nUnitConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitConsoleTest
{
    [TestFixture]
    public class Class1
    {
        List<EmployeeDetails> li;

        [Test]
        public void CheckDetails()
        {
            Program pObj = new Program();
            li = pObj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.id);
                Assert.IsNotNull(x.Name);
                Assert.IsNotNull(x.salary);
                Assert.IsNotNull(x.Gender);
            }
        }

        [Test]
        public void TestLogin()
        {
            Program pObj = new Program();
            string x = pObj.Login("xyz", "1234");
            string y = pObj.Login("", "");
            string z = pObj.Login("Admin", "Admin");

            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Welcome Admin.", z);
            Assert.AreEqual("Incorrect UserId or Password.", x);
        }

        [Test]
        public void GetUserDetails()
        {
            Program pObj = new Program();
            var p = pObj.getDetails(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.id, 100);
                Assert.AreEqual(x.Name, "Bharat");
            }
        }
    }
}
