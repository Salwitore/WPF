using LoginExample.ViewModels;
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

namespace LoginExample
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public LoginModel loginModel { get; set; } = new LoginModel();

        public View()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var password = loginModel.Users.GetValueOrDefault(UsernameTxtBox.Text);

            if (password != null && PasswordBox.Password.Equals(password))
            {
                WelcomeView welcomeView= new WelcomeView(UsernameTxtBox.Text);
                welcomeView.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!","WARNING",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }
    }
}
