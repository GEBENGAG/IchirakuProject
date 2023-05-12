using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        static ichirakuEntities entities = new ichirakuEntities();
        static int status = entities.СтатусЗаказа.Find(1).ИдСтатусаЗаказа;

        public MainWindow()
        {
            
            

        
            InitializeComponent();
            MainFrame.Content = new Authorize();
            OrdersGrid.ItemsSource = entities.Заказ.Where(k=>k.СтатусЗаказа1.ИдСтатусаЗаказа.Equals(status)).ToList();
             
            
        }
        private void OrderStatusChange_Click(object sender, RoutedEventArgs e)
        {
            
            int id = ((IshirakuCooker.Заказ)OrdersGrid.CurrentItem).ИдЗаказа;
            entities.Заказ.Find(id).СтатусЗаказа1 = entities.СтатусЗаказа.Find(3);
            entities.SaveChanges();
            OrdersGrid.ItemsSource = entities.Заказ.Where(k=>k.СтатусЗаказа1.ИдСтатусаЗаказа.Equals(status)).ToList();

        }

        private void updateGrid_Click(object sender, RoutedEventArgs e)
        {
            OrdersGrid.ItemsSource = entities.Заказ.Where(k => k.СтатусЗаказа1.ИдСтатусаЗаказа.Equals(status)).ToList();

        }
    }
}
