using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_application_for_registration_and_authorization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AuthTest()
        {
            MainWindow page = new MainWindow();

            Assert.IsTrue(page.Auth("admin", "P@ssw0rd123"));
            Assert.IsFalse(page.Auth("user1", "UserPass"));
            Assert.IsFalse(page.Auth("", ""));
            Assert.IsFalse(page.Auth(" ", " "));
        }
    }
}
