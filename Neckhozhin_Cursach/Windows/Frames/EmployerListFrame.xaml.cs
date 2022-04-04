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
    /// Логика взаимодействия для EmployerListFrame.xaml
    /// </summary>
    public partial class EmployerListFrame : Page
    {
        public EmployerListFrame()
        {
            InitializeComponent();
        }

        private void Employee_Test_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void CreatorTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmployerLV.ItemsSource = DataBaseConnection.entities.Employers.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
