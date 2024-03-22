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

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Log, Pass;
        string l1, l2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Log = tb_Log.Text;
            Pass = tb_Pass.Password;
        /*    for (int i = 0; i < ClassDebug.log.Length; i++)
            {
                l1 = ClassDebug.log[i];
                l2 = ClassDebug.pass[i];
                if (Pass == ClassDebug.pass[i] && Log == ClassDebug.log[i])
                    return;
                else
                    break;
            } */
            if (Pass == null && Log == null)
            {
                MessageBox.Show("Неверный логин пароль");
            }

            else if (Pass == ClassDebug.Test1 && Log == ClassDebug.Test)
            {
                ClassDebug.res = true;
                Close();
            }
            else
                return;
        }

        private void Label_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            Registr kl = new Registr();
            kl.Show();
            this.Close();
        }
    }
}
