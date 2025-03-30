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
    /// Логика взаимодействия для CapchaWindow.xaml
    /// </summary>
    public partial class CapchaWindow : Window
    {
        private string _currentCaptcha;

        public CapchaWindow()
        {
            InitializeComponent(); 
            GenerateNewCaptcha();
        }

        private void GenerateNewCaptcha()
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // Исключаем легко путаемые символы (0/O, 1/I)
            var random = new Random();
            _currentCaptcha = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            CaptchaText.Text = _currentCaptcha;

            // Добавляем визуальные помехи
            CaptchaText.Foreground = new SolidColorBrush(
                Color.FromRgb((byte)random.Next(100, 200),
                             (byte)random.Next(100, 200),
                             (byte)random.Next(100, 200)));

            var canvas = new Canvas();
            var visualBrush = new VisualBrush(CaptchaText) { Opacity = 0.1 };
            canvas.Background = visualBrush;
        }

        public bool Checked_Method()
        {
            bool f = true;
            return f;
        }

        private void CheckCaptcha_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text.Equals(_currentCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                ResultText.Text = "✅ Верно!";
                ResultText.Foreground = Brushes.Green;
                Checked_Method();
                this.DialogResult = true;
                this.Close();

            }
            else
            {
                ResultText.Text = "❌ Неверно. Попробуйте еще раз.";
                ResultText.Foreground = Brushes.Red;
                GenerateNewCaptcha(); // Обновляем капчу
            }
            UserInput.Clear();
        }
    }
}
