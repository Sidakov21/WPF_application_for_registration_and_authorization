using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_application_for_registration_and_authorization
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int countAttempts = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool Auth(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }

            using (var db = new UsersEntities2())
            {
                var user = db.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user == null)
                {
                    countAttempts++;
                    if (countAttempts > 3)
                    {
                        MessageBox.Show("Превышено количество неудачных попыток.\n Пройдите капчу");
                        Enter_button.IsEnabled = false;

                        CapchaWindow capcha = new CapchaWindow();
                        bool? captchaResult = capcha.ShowDialog();

                        // Проверяем результат диалога
                        if (captchaResult == true)
                        {
                            Enter_button.IsEnabled = true;
                            countAttempts = 0;
                        }
                        return false;
                    }
                    MessageBox.Show("Пользователь с такими данными не найден!");

                    return false;
                }
                else
                {
                    MessageBox.Show($"С возвращением, {user.Role}, {user.FIO.Split()[1]}!");
                    TextBoxLogin.Clear();
                    PasswordBoxPassword.Clear();
                    return true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Auth(TextBoxLogin.Text, PasswordBoxPassword.Password);
        }

        private void ButtonRegister_OnClick(object sender, RoutedEventArgs e)
        {
            RegPage regPage = new RegPage();
            regPage.Show();
            this.Close();
        }
    }
}
