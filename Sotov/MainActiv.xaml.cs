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
    /// Логика взаимодействия для MainActiv.xaml
    /// </summary>
    public partial class MainActiv : Window
    {
        public MainActiv()
        {
            InitializeComponent();
        }

        private void Kabinet_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow kl = new MainWindow();
            kl.Show();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
