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
using Neckhozhin_Cursach.Class;
using Neckhozhin_Cursach.DataBase;

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для WarehouseCostumablesFrame.xaml
    /// </summary>
    public partial class WarehouseCostumablesFrame : Page
    {
        public WarehouseCostumablesFrame()
        {
            InitializeComponent();
            try
            {
                CostumablesLV.ItemsSource = DataBaseConnection.entities.Costumables_Warehouse.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterNameCostumableBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CostumablesLV.ItemsSource = DataBaseConnection.entities.Costumables_Warehouse.Where(i => i.Costumables.Name_C.Contains(FilterNameCostumableTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterMaterialBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CostumablesLV.ItemsSource = DataBaseConnection.entities.Costumables_Warehouse.Where(i => i.Costumables.Name_C.Contains(FilterMaterialTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
