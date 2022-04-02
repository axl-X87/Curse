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

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для SelectWarehouseFrame.xaml
    /// </summary>
    public partial class SelectWarehouseFrame : Page
    {
        public SelectWarehouseFrame()
        {
            InitializeComponent();
        }

        private void DetailsWarehouseNavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WarehouseDetailsFrame());
        }

        private void PaintWarehouseNavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WarehousePaintFrame());
        }

        private void CostumablesWarehouseNavigateBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WarehouseCostumablesFrame());
        }
    }
}
