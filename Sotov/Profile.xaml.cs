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
                    else if(chill is StackPanel stackPanel)
                    {
                        TextBlock description = stackPanel.Children[0] as TextBlock;
                        TextBlock price = stackPanel.Children[1] as TextBlock;
                    }
                }
            }
        }

        private void click(object sender, RoutedEventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            StackPanel stack = check.Parent as StackPanel;
            stack = stack.Children[1] as StackPanel;
            TextBlock description = stack.Children[0] as TextBlock;
            TextBlock cost = stack.Children[1] as TextBlock;
            string hleb = cost.Text.TrimEnd('₽').Split()[1];

            if (check.IsChecked.Value)
            {
                Spisok.Text += description.Text + "\n";
                SotovHelper.price += int.Parse(hleb);
            }
            else
            {
                Spisok.Text = Spisok.Text.Replace(description.Text + "\n", "");
                SotovHelper.price -= int.Parse(hleb);
            }
            Costs.Text = "Итого: " + SotovHelper.price.ToString() + "₽";
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
            SotovHelper.cost = Costs.Text.TrimStart();

            Offert offert = new Offert();
            offert.Show();
        }
    }
}
