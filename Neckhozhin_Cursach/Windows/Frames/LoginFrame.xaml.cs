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
    /// Логика взаимодействия для LoginFrame.xaml
    /// </summary>
    public partial class LoginFrame : Page
    {
        public LoginFrame()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User_App user = DataBaseConnection.entities.User_App.Where(i => i.UserName == LoginTBx.Text && i.UserPassword == PasswwordPBx.Password).FirstOrDefault();
                if (user != null)
                {
                    MenuShowHelper.menu.Visibility = Visibility.Visible;
                    MenuShowHelper.frame.Visibility = Visibility.Visible;
                    NavigationService.Navigate(new PersonalFrame(user));
                    LoginTBx.Text = "";
                    PasswwordPBx.Password = "";
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль","Неверные данные для входа",MessageBoxButton.OK ,MessageBoxImage.Information);
                    PasswwordPBx.Password = "";
                }
            }
            catch
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
