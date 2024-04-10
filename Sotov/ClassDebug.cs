using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;
using System.Xml;

namespace Sotov
{
    public static class ClassDebug
    {
        public static bool res = false;
    }

    public partial class Maket
    {
        public string Clone(string a, string b)
        {
            string result = null;
            string clone = XamlWriter.Save(b);
            byte[] byteArray = Encoding.UTF8.GetBytes(clone);
            MemoryStream ms = new MemoryStream(byteArray);
            StreamReader str = new StreamReader(ms);
            XmlReader xamel = XmlReader.Create(str);
            StackPanel reder = (StackPanel)XamlReader.Load(xamel);

            return result;
        }
    }
}
