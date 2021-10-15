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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppEvents
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonNewMessage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPopularMessages_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxLogin.Text) && !string.IsNullOrEmpty(PasswordBoxPassword.Password))
            {

                if (TextBoxLogin.Text == Helper.GetContext().staff.FirstOrDefault(x => x.Log.Contains(TextBoxLogin.Text)).Log
                    && PasswordBoxPassword.Password == Helper.GetContext().staff.FirstOrDefault(x => x.Pass.Contains(PasswordBoxPassword.Password)).Pass)


                {
                    MessageBox.Show("Авторизация успешна", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Авторизация не успешна. Не верны логин или пароль", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }



            else
            {
                MessageBox.Show("Авторизация не успешна. Не заполнены поля логина или пароля", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
