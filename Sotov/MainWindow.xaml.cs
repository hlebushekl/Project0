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
using System.Data.OleDb;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            string log = tb_Log.Text;
            string pass = tb_Pass.Password;
            OleDbDataReader reader;
            OleDbConnection connection = DataReader.Connection;
            OleDbCommand command;
            string src = $@"SELECT * FROM Авторизация WHERE Логин = '{log}' AND Пароль = '{pass}'";
            string FinderName = $@"SELECT Имя FROM Авторизация WHERE Логин = '{log}'";
            string FinderPhone = $@"SELECT Номер_телефона FROM Авторизация WHERE Логин = '{log}'";

            connection.Open();

            command = new OleDbCommand(FinderName, connection);
            reader = command.ExecuteReader();
            reader.Read();
            SotovHelper.name = reader[0].ToString();

            command = new OleDbCommand(FinderPhone, connection);
            reader = command.ExecuteReader();
            reader.Read();
            SotovHelper.phone = reader[0].ToString();

            command = new OleDbCommand(src, connection);
            reader = command.ExecuteReader();

            if(reader.Read())
            {
                MessageBox.Show("Добро пожаловать " + SotovHelper.name);
                Profile kl = new Profile();
                kl.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неверный пароль");
            connection.Close();
        }

        private void Label_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            Registr kl = new Registr();
            kl.Show();
            this.Close();
        }
    }
}
