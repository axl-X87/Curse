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
    /// Логика взаимодействия для PersonalFrame.xaml
    /// </summary>
    public partial class PersonalFrame : Page
    {
        public PersonalFrame(User_App user)
        {
            InitializeComponent();
            DataContext = user;
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            NavigationService.GoBack();
            MenuShowHelper.menu.Visibility = Visibility.Hidden;
            MenuShowHelper.frame.Navigate(null);
            MenuShowHelper.frame.Visibility = Visibility.Hidden;
        }
    }
}
