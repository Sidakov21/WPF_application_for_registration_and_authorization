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

        private void ButtonRegister_OnClick(object sender, RoutedEventArgs e)
        {
            // Проверка на заполненность всех полей
            if (string.IsNullOrEmpty(TextBoxFIO.Text) ||
                string.IsNullOrEmpty(TextBoxLogin.Text) ||
                string.IsNullOrEmpty(PasswordBox.Password) ||
                ComboBoxGender.SelectedItem == null ||
                ComboBoxRole.SelectedItem == null ||
                string.IsNullOrEmpty(TextBoxPhone.Text) ||
                string.IsNullOrEmpty(TextBoxPhoto.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            using (var db = new UsersEntities2())
            {

                var existingUser = db.User.FirstOrDefault(u => u.Login == TextBoxLogin.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Логин уже существует! Выберите другой.");
                    return;
                }

                var newUser = new User
                {
                    FIO = TextBoxFIO.Text,
                    Login = TextBoxLogin.Text,
                    Password = PasswordBox.Password,
                    Gender = ComboBoxGender.Text,
                    Role = ComboBoxRole.Text,
                    Phone = TextBoxPhone.Text,
                    Photo = TextBoxPhoto.Text
                };

                db.User.Add(newUser);
                db.SaveChanges();
            }

            MessageBox.Show("Регистрация успешно завершена!");
            this.Close();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

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
