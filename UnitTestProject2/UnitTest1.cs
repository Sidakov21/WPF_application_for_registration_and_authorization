using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_application_for_registration_and_authorization;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExceededTheLimitOfFailedAttempts()
        {
            CapchaWindow capcha = new CapchaWindow();
            Assert.IsTrue(capcha.Checked_Method());
        }
    }
}
