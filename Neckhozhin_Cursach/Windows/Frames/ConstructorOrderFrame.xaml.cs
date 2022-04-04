
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
    /// Логика взаимодействия для ConstructorOrderFrame.xaml
    /// </summary>
    public partial class ConstructorOrderFrame : Page
    {
        public ConstructorOrderFrame()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Order_ order = new Order_();
            if (ProductListCB.SelectedIndex != -1 && PaintListCB.SelectedIndex != -1)
            {
                try
                {
                    order.Product = (ProductListCB.SelectedIndex + 2);
                    order.Paint = (PaintListCB.SelectedIndex + 1);
                    order.Amount_Product = Convert.ToInt32(AmountProductTB.Text);
                    order.Total_Area_Value = DataBaseConnection.entities.Product.Where(i => i.id_P == (ProductListCB.SelectedIndex + 2)).Select(i => i.Size_Value_P).FirstOrDefault();
                    order.Tatal_Area = DataBaseConnection.entities.Product.Where(i => i.id_P == (ProductListCB.SelectedIndex + 2)).Select(i => i.Size_P).FirstOrDefault() * Convert.ToInt32(AmountProductTB.Text);
                    order.Paint = (PaintListCB.SelectedIndex + 1);
                    DataBaseConnection.entities.Order_.Add(order);
                    DataBaseConnection.entities.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Обратитесь к администратору", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
        }

        private void NameProductsearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void ProductListCB_DropDownOpened(object sender, EventArgs e)
        {
            try
            {
                ProductListCB.ItemsSource = DataBaseConnection.entities.Product.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PaintListCB_DropDownOpened(object sender, EventArgs e)
        {
            try
            {
                ProductListCB.ItemsSource = DataBaseConnection.entities.Paint.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PaintListCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ShowColorB.Background = (Brush)new BrushConverter().ConvertFromString(DataBaseConnection.entities.Paint.Where(i => i.id_P == (PaintListCB.SelectedIndex + 1)).Select(i => i.ISO_P).FirstOrDefault());
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
