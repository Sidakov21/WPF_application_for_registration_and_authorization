using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_application_for_registration_and_authorization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void Register_check()
        {
            MainWindow page = new MainWindow();
            Assert.IsTrue(page.Auth("ADmIN", "P@ssw0rd123"));
            Assert.IsTrue(page.Auth("UseR1", "UserPass123"));
            Assert.IsTrue(page.Auth("anALYST1", "AnalystPass1!"));
            Assert.IsTrue(page.Auth("MANAGer1", "SecurePass1"));
        }
    }
}
