using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Sotov
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
            string clone = XamlWriter.Save(Soup);
            Stack.Children.Clear();
            for (int i = 0; i < Maket.Lenght(); i++)
            {
                Stack.Children.Add(Maket.Clone(clone, i));
                StackPanel parent = Stack.Children[i] as StackPanel;
                
                foreach(UIElement chill in parent.Children)
                {
                    if(chill is CheckBox check)
                    {
                        check.Click += click;
                    }
                }
            }
        }

        private void click(object sender, RoutedEventArgs e)
        {
            CheckBox check = (CheckBox)sender;
        }

        private void Return_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ClassDebug.res = false;
            Close();
        }

        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close ();
        }

        private void bt_Offert_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
