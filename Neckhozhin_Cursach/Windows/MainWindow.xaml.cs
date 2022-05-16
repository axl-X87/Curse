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
using Neckhozhin_Cursach.Windows.Frames;

namespace Neckhozhin_Cursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            PersonalFrame.Navigate(new LoginFrame());
            MenuPanel.Visibility = Visibility.Hidden;
            MenuShowHelper.menu = MenuPanel;
            MenuShowHelper.frame = MainFrame;
        }

        private void Employer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Employer());
        }

        private void Warehouse_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SelectWarehouseFrame());
        }

        private void CreateSupply_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CreateSupply());
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Order());
        }
    }
}
