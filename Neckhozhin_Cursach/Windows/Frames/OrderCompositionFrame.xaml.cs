using Neckhozhin_Cursach.Class;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для OrderCompositionFrame.xaml
    /// </summary>
    public partial class OrderCompositionFrame : Page
    {
        public OrderCompositionFrame()
        {
            InitializeComponent();
        }

        private void ShowOrders_Click(object sender, RoutedEventArgs e)
        {
            OrderVL.ItemsSource = DataBaseConnection.entities.Order_.ToList();
        }

        private void OrderVL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Test666_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
