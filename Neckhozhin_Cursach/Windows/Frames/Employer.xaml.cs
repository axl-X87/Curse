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
using Neckhozhin_Cursach.Windows.Frames;
using Neckhozhin_Cursach.Class;
using Neckhozhin_Cursach.Windows;

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для Employer.xaml
    /// </summary>
    public partial class Employer : Page
    {
        public Employer()
        {
            InitializeComponent();
        }

        private void EmployerListBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployerListFrame());
        }

        private void AddEmployerBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddEmployerFrame());
        }
    }
}
