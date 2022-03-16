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
            PersonalFrame.Navigate(new Windows.Frames.LoginFrame());
        }

        private void Employer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Windows.Frames.Employer());
        }

        private void AddEmploer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Windows.Frames.AddEmployerFrame());
        }

        private void OrderComposition_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Windows.Frames.OrderCompositionFrame());
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Windows.Frames.ConstructorOrderFrame());
        }
    }
}
