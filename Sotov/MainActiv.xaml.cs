using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Controls;

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
            string clone = XamlWriter.Save(Makeup);
            MainClone.Children.Clear();
            for (int i = 0; i < Maket.Lenght(); i++ )
               MainClone.Children.Add(Maket.Clone(clone, i));
        }


        private void Kabinet_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (ClassDebug.res == false)
            {
                MainWindow kl = new MainWindow();
                kl.Show();
            }
            else if (ClassDebug.res == true)
            {
                Profile lk = new Profile();
                lk.Show();
            }
            else
                return;
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Secret_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
