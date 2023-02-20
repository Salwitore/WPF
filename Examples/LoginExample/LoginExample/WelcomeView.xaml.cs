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
    /// Interaction logic for WelcomeView.xaml
    /// </summary>
    public partial class WelcomeView : Window
    {
        public string Username { get; set; }
        public WelcomeView(string username)
        {
            InitializeComponent();
            this.Username = username;
            UsernameTxtValue.Text = Username;
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Sayın {Username},\nÇıkmak istediğinizden eminmisiniz?", "Çıkış", MessageBoxButton.YesNo, MessageBoxImage.Question);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    View view = new View();
                    view.Show();
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
    }
}
