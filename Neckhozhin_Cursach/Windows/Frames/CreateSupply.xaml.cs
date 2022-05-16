using Neckhozhin_Cursach.DataBase;
using Neckhozhin_Cursach.Class;
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
    /// Логика взаимодействия для CreateSupply.xaml
    /// </summary>
    public partial class CreateSupply : Page
    {
        public CreateSupply()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (TypeCb.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Supply_Details supplyD = new Supply_Details();
                        supplyD.id_D = DataBaseConnection.entities.Product.Where(i => i.Name_P == NameCb.Text).Select(o => o.id_P).FirstOrDefault();
                        supplyD.Amount = Convert.ToInt32(CountTbx.Text);
                        DataBaseConnection.entities.Supply_Details.Add(supplyD);
                        DataBaseConnection.entities.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Обратитесь к администратору", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 1:
                    try
                    {
                        Supply_Paint supplyP = new Supply_Paint();
                        supplyP.id_P = DataBaseConnection.entities.Paint.Where(i => i.Name_Color_P == NameCb.Text).Select(o => o.id_P).FirstOrDefault();
                        supplyP.Amount = Convert.ToInt32(CountTbx.Text);
                        DataBaseConnection.entities.Supply_Paint.Add(supplyP);
                        DataBaseConnection.entities.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Обратитесь к администратору", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 2:
                    try
                    {
                        Supply_Costumables supplyC = new Supply_Costumables();
                        supplyC.id_P = DataBaseConnection.entities.Costumables.Where(i => i.Name_C == NameCb.Text).Select(o => o.id_C).FirstOrDefault();
                        supplyC.Amount = Convert.ToInt32(CountTbx.Text);
                        DataBaseConnection.entities.Supply_Costumables.Add(supplyC);
                        DataBaseConnection.entities.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Обратитесь к администратору", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    }                    
                    break;
            }
            MessageBox.Show("Тип продукции : " + TypeCb.Text.ToString()+"\nНазвание продукции : " + NameCb.Text + "\nКоличество : " + CountTbx.Text);
        }

        private void TypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TypeCb.SelectedIndex)
            {
                case 0:
                    NameCb.ItemsSource = DataBaseConnection.entities.Product.Select(i => i.Name_P).ToList();
                    break;
                case 1:
                    NameCb.ItemsSource = DataBaseConnection.entities.Paint.Select(i => i.Name_Color_P).ToList();
                    break;
                case 2:
                    NameCb.ItemsSource = DataBaseConnection.entities.Costumables.Select(i => i.Name_C).ToList();
                    break;
            }
        }
    }
}
