using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using System.Data;

namespace Sotov
{
    //Не ьейте оно само
    public static class SotovHelper
    {
        public static string name = null;
        public static string phone = null;
        public static string type = null;
        public static int price = 0;
    }
    public static class ClassDebug
    {
        public static bool res = false;
    }
    /// <summary>
    /// Активная шаблонизация
    /// </summary>
    public class Maket
    {
        //Константы для изменения шаблона
        static readonly string Name = "6.73&quot; Смартфон Xiaomi 13 Pro 512 ГБ черный";
        static readonly string Price = "Ценна: 109999₽";
        static readonly string Picture = "/Resurs/Mi13Pro.png";

        /// <summary>
        /// Вытаскивает таблицу
        /// </summary>
        /// <returns>Data.Tabels</returns>
        public static DataTable Data()
        {
            string NameTable = "Модель";
            OleDbConnection connection = DataReader.Connection;

            connection.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {NameTable}", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);

            connection.Close();

            return data.Tables[0];
        }

        /// <summary>
        /// Обработчик таблицы подтянутой из бд
        /// </summary>
        /// <param name="i">Строка</param>
        /// <param name="j">Столбец</param>
        /// <returns>Возвращает строку данных</returns>
        public static string TabelInsertion(int i, int j)
        {
            string result;

            DataTable table = Data();
            result = table.Rows[i][j].ToString();

            return result;
        }

        /// <summary>
        /// Создание шаблона, изменение его и последующая отправка обратно
        /// </summary>
        /// <param name="res">Шаблон</param>
        /// <returns>Поток байтов для создания нового элемента согласно шаблону</returns>
        public static UIElement Clone(string res, int i)
        {
            string ret = res.Replace(Name, TabelInsertion(i, 2));
            ret = ret.Replace(Price, "Ценна: " + TabelInsertion(i, 5) + "₽");
            ret = ret.Replace(Picture, PhotoAdapter(i));

            byte[] byteArray = Encoding.UTF8.GetBytes(ret);
            MemoryStream ms = new MemoryStream(byteArray);
            StreamReader str = new StreamReader(ms);
            XmlReader xamel = XmlReader.Create(str);
            StackPanel reder = (StackPanel)XamlReader.Load(xamel);

            return reder;
        }

        /// <summary>
        /// Определяет количество строк в таблице
        /// </summary>
        /// <returns>Число</returns>
        public static int Lenght()
        {
            int result;

            DataTable table = Data();
            result = table.Rows.Count;

            return result;
        }

        /// <summary>
        /// Обработчик для подстановки фотки
        /// </summary>
        /// <returns>Возвращает ссылку на фото</returns>
        public static string PhotoAdapter(int i)
        {
            string result;

            DataTable tabel = Data();
            string operation = tabel.Rows[i][4].ToString();
            result = Path.Combine("/Resurs", operation);

            return result;
        }
    }

    public class DataReader
    {
        /// <summary>
        /// Подключение к бд
        /// </summary>
        public static OleDbConnection Connection
        {
            get { return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FirstTry.accdb"); }
        }
    }
}
