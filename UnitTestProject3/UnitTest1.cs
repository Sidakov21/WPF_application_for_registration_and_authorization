using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPF_application_for_registration_and_authorization;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectData()
        {
            RegPage page = new RegPage();
            Assert.IsTrue(page.Registration("Николаев Артем Викторович", "fin_analyst2", "Fin@Analysis1", "Мужской", "Analyst", "+7 (495) 333-44-55", "https://example.com/photos/fin_analyst.jpg"));
            Assert.IsTrue(page.Registration("Петров Денис Олегович", "sales_mng5", "Sales2024!", "Мужской", "Manager", "+7 (495) 777-88-99", "https://example.com/photos/sales_manager.jpg"));
            Assert.IsTrue(page.Registration("Тихомирова Ольга Игоревна", "hr_use51", "HRuserPass1", "Женский", "User", "+7 (495) 999-00-11", "https://example.com/photos/hr_user.jpg"));
        }

        [TestMethod]
        public void IncorrectData()
        {
            RegPage page = new RegPage();
            Assert.IsFalse(page.Registration("Иванов Иван Иванович", "admin", "P@ssw0rd123", "Мужской", "Administrator", "+7 (495) 123-45-67", "https://example.com/photos/admin.jpg"));
            Assert.IsFalse(page.Registration("Петров Денис Олегович", "sales_mng4", "", "Мужской", "Manager", "+7 (495) 777-88-99", "https://example.com/photos/sales_manager.jpg"));
            Assert.IsFalse(page.Registration("Тихомирова Ольга Игоревна", "hr_user4", "HRuserPass1", "", "User", "+7 (495) 999-00-11", "https://example.com/photos/hr_user.jpg"));
        }

        [TestMethod]
        public void EmptyOrNullData()
        {
            RegPage page = new RegPage();
            Assert.IsFalse(page.Registration("", "", "", "", "", "", ""));
            Assert.IsFalse(page.Registration("Оченьдлиннаяфамилия Оченьдлинноеимя Оченьдлинноеотчество", "very_long_username_1234567890", "P@ssw0rdWithMaxLength32symbols!!", "Женский", null, null, "https://example.com/very/long/url/to/user/photo/which/exceeds/standard/length/limits/user_photo.jpg"));
            Assert.IsFalse(page.Registration(" ", " ", " ", " ", " ", " ", " "));
        }

    }
}
