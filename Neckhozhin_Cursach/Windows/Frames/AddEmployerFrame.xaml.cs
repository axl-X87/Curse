using System;
using System.Collections.Generic;
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
using Neckhozhin_Cursach.Class;
using Neckhozhin_Cursach.DataBase;

namespace Neckhozhin_Cursach.Windows.Frames
{
    /// <summary>
    /// Логика взаимодействия для AddEmployerFrame.xaml
    /// </summary>
    public partial class AddEmployerFrame : Page
    {
        public AddEmployerFrame()
        {
            InitializeComponent();
            
        }

        private void Test1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddEmployer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employers emp = new Employers();
                emp.Surname_E = SurnameEmployer.Text;
                emp.Name_E = NameEmployer.Text;
                emp.Patronymic_e = PatronymicEmployer.Text;
                emp.Position_E = (Convert.ToInt32(EmployeePositionCB.SelectedIndex) + 1);
                DataBaseConnection.entities.Employers.Add(emp);
                DataBaseConnection.entities.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EmployeePositionCB_DropDownOpened(object sender, EventArgs e)
        {
            try
            {
                EmployeePositionCB.ItemsSource = DataBaseConnection.entities.Positions.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Обратитесь к администратору", "Ошибка вывода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
//SqlCommand cmd = new SqlCommand(QueryUsing.insertEmployer, DataBaseConnection.connect);
//cmd.Parameters.AddWithValue("@Surname_E", SurnameEmployer.Text);
//cmd.Parameters.AddWithValue("@Name_E", NameEmployer.Text);
//cmd.Parameters.AddWithValue("@Patronymic_e", PatronymicEmployer.Text);
//cmd.Parameters.AddWithValue("@Position_E", (Convert.ToInt32(Test1.SelectedIndex) +1));
//cmd.ExecuteNonQuery();