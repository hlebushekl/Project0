using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Data.OleDb;
using System.Data;

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
            OleDbDataReader read;
            OleDbConnection connection = DataReader.Connection;
            OleDbCommand command;
            string model = $@"SELECT Адресс FROM Пункты";

            connection.Open();

            command = new OleDbCommand(model, connection);
            read = command.ExecuteReader();

            while (read.Read())
            {
                CB_dost.Items.Add(read["Адресс"].ToString());
            }

            connection.Close();

            tb_Name.Text = SotovHelper.name;
            tb_Phone.Text = SotovHelper.phone;
        }

        private void Return_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = DataReader.Connection;
            OleDbDataAdapter ad;
            DataSet ds = new DataSet();

            connection.Open();
            ad = new OleDbDataAdapter("SELECT * FROM Продажи", connection);
            ad.Fill(ds);

            DataRow dr = ds.Tables[0].NewRow();
            dr["Имя_Заказчика"] = tb_Name.Text;
            dr["Номер_телефона"] = tb_Phone.Text;
            dr["Заказ"] = tb_Zakaz.Text;
            dr["Адресс_доставки"] = CB_dost.Text;
            dr["Стоимость"] = SotovHelper.price;
            dr["Тип_оплаты"] = SotovHelper.type;

            ds.Tables[0].Rows.Add(dr);

            OleDbCommandBuilder build = new OleDbCommandBuilder(ad);
            ad.Update(ds);
        }

        private void cb_Nal_Checked(object sender, RoutedEventArgs e)
        {
            cb_Online.IsEnabled = false;
            SotovHelper.type = "Наличные";
        }

        private void cb_Online_Checked(object sender, RoutedEventArgs e)
        {
            cb_Nal.IsEnabled = false;
            SotovHelper.type = "Онлайн";
        }

        private void cb_Nal_Unchecked(object sender, RoutedEventArgs e)
        {
            cb_Online.IsEnabled = true;
        }

        private void cb_Online_Unchecked(object sender, RoutedEventArgs e)
        {
            cb_Nal.IsEnabled = true;
        }

    }
}
