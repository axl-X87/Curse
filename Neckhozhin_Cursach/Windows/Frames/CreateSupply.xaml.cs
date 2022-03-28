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
            MessageBox.Show("Тип продукции : " + TypeCb.Text.ToString()+"\n Название продукции : " + NameTbx.Text + "\n Количество : " + CountTbx.Text);
        }

        private void TypeCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
