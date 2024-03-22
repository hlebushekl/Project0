using System;
using System.Windows;
using System.Windows.Input;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        string Log, Pass, NameL, Number;
        int kl = ClassDebug.i;
        public Registr()
        {
            InitializeComponent();
        }

        private void bt_Registr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Log = Convert.ToString(tb_Log.Text);
            Pass = Convert.ToString(tb_Pass.Text);
            NameL = Convert.ToString(tb_Name.Text);
            Number = Convert.ToString(tb_Nomer.Text);

            if (Log == null || Pass == null || NameL == null || Number == null)
                MessageBox.Show("Все поля должны быть заполнены");
            else if (Log != null || Pass != null || NameL != null || Number != null)
            {
                ClassDebug.Test = Log;
                ClassDebug.Test1 = Pass;
                ClassDebug.i++;
                MessageBox.Show("Регистрация прошла успешно");
                MainWindow lk = new MainWindow();
                lk.Show();
                Close();
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
