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
using Neckhozhin_Cursach.DataBase;
using Neckhozhin_Cursach.Class;

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для WarehouseDetailsFrame.xaml
    /// </summary>
    public partial class WarehouseDetailsFrame : Page
    {
        public WarehouseDetailsFrame()
        {
            InitializeComponent();
            try
            {
                ProductListLV.ItemsSource = DataBaseConnection.entities.Products_Warehouse.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterNameBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductListLV.ItemsSource = DataBaseConnection.entities.Products_Warehouse.Where(i => i.Product.Name_P.Contains(FilterNameTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterThicknessBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProductListLV.ItemsSource = DataBaseConnection.entities.Products_Warehouse.Where(i => i.Product.Name_P.Contains(FilterThicknessTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
