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
using System.Data.OleDb;
using System.Data;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            OleDbDataReader read;
            OleDbConnection connection = DataReader.Connection;
            OleDbCommand command;
            string model = $@"SELECT Производитель FROM Модель";

            connection.Open();

            command = new OleDbCommand(model, connection);
            read = command.ExecuteReader();

            while(read.Read())
            {
                CB_Model.Items.Add(read["Производитель"].ToString());
            }

            connection.Close();
        }

        private void bt_Add_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection connection = DataReader.Connection;
            OleDbDataAdapter ad;
            DataSet ds = new DataSet();

            connection.Open();

            ad = new OleDbDataAdapter("SELECT * FROM Модель", connection);
            ad.Fill(ds);

            DataRow dr = ds.Tables[0].NewRow();
            dr["Производитель"] = CB_Model.Text;
            dr["Модель"] = TB_Name.Text;
            dr["Объем"] = TB_pzu.Text;
            dr["Стоимость"] = TB_Cost.Text;
            dr["Цвет"] = tb_URL.Text;

            ds.Tables[0].Rows.Add(dr);
            OleDbCommandBuilder build = new OleDbCommandBuilder(ad);
            ad.Update(ds);
            connection.Close();

            MessageBox.Show("Успешно добавленно");
        }

        private void Return_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
