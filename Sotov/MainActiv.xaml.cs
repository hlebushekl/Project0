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
using System.Windows.Markup;
using System.IO;
using System.Xml;

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
            byte[] byteArray = Encoding.UTF8.GetBytes(clone);
            MemoryStream ms = new MemoryStream(byteArray);
            StreamReader str = new StreamReader(ms);
            XmlReader xamel = XmlReader.Create(str);
            StackPanel reder = (StackPanel)XamlReader.Load(xamel);

            MainClone.Children.Add(reder);
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
    }
}
