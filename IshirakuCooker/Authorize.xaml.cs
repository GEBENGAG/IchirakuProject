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

namespace IshirakuCooker
{
    /// <summary>
    /// Логика взаимодействия для Authorize.xaml
    /// </summary>
    public partial class Authorize : Page
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        { 
            MainWindow main = new MainWindow();
            main.MainFrame.Content = null;
            main.MainFrame.IsEnabled = false;

        }
    }
}
