﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_application_for_registration_and_authorization;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AuthTestSuccess()
        {
            MainWindow page = new MainWindow();
            Assert.IsTrue(page.Auth("admin", "P@ssw0rd123"));
            Assert.IsTrue(page.Auth("user1", "UserPass123"));
            Assert.IsTrue(page.Auth("analyst1", "AnalystPass1!"));
            Assert.IsTrue(page.Auth("manager1", "SecurePass1"));
        }
    }
}
