using Neckhozhin_Cursach.Class;
using Neckhozhin_Cursach.DataBase;
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
    /// Логика взаимодействия для WarehousePaintFrame.xaml
    /// </summary>
    public partial class WarehousePaintFrame : Page
    {
        public WarehousePaintFrame()
        {
            InitializeComponent();
            try
            {
                PaintLV.ItemsSource = DataBaseConnection.entities.Paint_Warehouse.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterISOBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PaintLV.ItemsSource = DataBaseConnection.entities.Paint_Warehouse.Where(i => i.Paint.ISO_P.Contains(FiltertISOTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FilterNamePaintBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PaintLV.ItemsSource = DataBaseConnection.entities.Paint_Warehouse.Where(i => i.Paint.ISO_P.Contains(FilterNamePaintTbx.Text)).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
