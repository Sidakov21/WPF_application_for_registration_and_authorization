using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_application_for_registration_and_authorization
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Window
    {
        public RegPage()
        {
            InitializeComponent();
        }

        public bool Registration(string fio, string login, string password, string gender, string role, string phone, string photoURL)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrEmpty(fio) ||
                string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(role) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(photoURL))
            {
                MessageBox.Show("Заполните все поля!");
                return false;
            }

            using (var db = new UsersEntities2())
            {

                var existingUser = db.User.FirstOrDefault(u => u.Login == login);
                if (existingUser != null)
                {
                    MessageBox.Show("Логин уже существует! Выберите другой.");
                    return false;
                }

                var newUser = new User
                {
                    FIO = fio,
                    Login = login,
                    Password = password,
                    Gender = gender,
                    Role = role,
                    Phone = phone,
                    Photo = photoURL
                };

                db.User.Add(newUser);
                db.SaveChanges();
            }

            MessageBox.Show("Регистрация успешно завершена!");
            this.Close();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

            return true;
        }

        private void ButtonRegister_OnClick(object sender, RoutedEventArgs e)
        {
            Registration(TextBoxFIO.Text, TextBoxLogin.Text, PasswordBox.Password, ComboBoxGender.SelectedItem.ToString(), ComboBoxRole.SelectedItem.ToString(), TextBoxPhone.Text, TextBoxPhoto.Text);

        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            // Очищаем все поля формы
            TextBoxFIO.Text = "";
            TextBoxLogin.Text = "";
            PasswordBox.Password = "";
            ComboBoxGender.SelectedIndex = -1;
            ComboBoxRole.SelectedIndex = -1;
            TextBoxPhone.Text = "";
            TextBoxPhoto.Text = "";

            // Открываем страницу авторизации
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();

            // Закрываем текущую страницу
            this.Close();
        }
    }
}
