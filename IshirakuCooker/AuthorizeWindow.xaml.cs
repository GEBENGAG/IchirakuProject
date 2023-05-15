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

namespace IshirakuCooker
{
    /// <summary>
    /// Логика взаимодействия для AuthorizeWindow.xaml
    /// </summary>
    public partial class AuthorizeWindow : Window
    {
        public AuthorizeWindow()
        {
            InitializeComponent();
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 2;

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 3;

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 4;

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 5;

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 6;

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 7;

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 8;

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password += 9;

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            fieldPassword.Password = null ;

        }
    }
}
