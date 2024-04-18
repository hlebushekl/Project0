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
using System.Windows.Shapes;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для Offert.xaml
    /// </summary>
    public partial class Offert : Window
    {
        public Offert()
        {
            InitializeComponent();
        }

        private void Return_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (i == 0)
            {
                
            }
        }

        private void cb_Nal_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cb_Online_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
