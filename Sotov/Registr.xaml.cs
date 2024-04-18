using System;
using System.Windows;
using System.Windows.Input;
using System.Data.OleDb;
using System.Data;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        public Registr()
        {
            InitializeComponent();
            tb_Nomer.MaxLength = 12;
        }

        private void bt_Registr_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (tb_Log.Text.Length == 0 || tb_Name.Text.Length == 0 || tb_Name.Text.Length == 0 || tb_Nomer.Text.Length == 0)
            {
                MessageBox.Show("Не все строки заполнены");
            }
            else
            {
               OleDbConnection connect = DataReader.Connection;
              OleDbDataAdapter ad;
              DataSet ds = new DataSet();
            
                connect.Open();
                ad = new OleDbDataAdapter("SELECT * FROM Авторизация", connect);
                ad.Fill(ds);

               DataRow dr = ds.Tables[0].NewRow();
               dr["Логин"] = tb_Log.Text;
               dr["Пароль"] = tb_Pass.Text;
               dr["Имя"] = tb_Name.Text;
               dr["Номер_телефона"] = tb_Nomer.Text;

                ds.Tables[0].Rows.Add(dr);

                OleDbCommandBuilder build = new OleDbCommandBuilder(ad);
                ad.Update(ds);

                if (tb_Name.Text == "Олег")
                {
                    MessageBox.Show("Ох Олежа, куда тебя понесло?");
                    MainWindow kl = new MainWindow();
                    kl.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Регистрация прошла успешно");
                    MainWindow kl = new MainWindow();
                    kl.Show();
                    this.Close();
                }
                connect.Close();
            }
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
