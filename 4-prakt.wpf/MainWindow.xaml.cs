using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace _4_prakt.wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string selected;
        List<Type> objects = new List<Type>();
        List<string> Guitar = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = objects;
            GuitarBox.ItemsSource = Guitar;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            objects.Add(new Type(NameType.Text, selected, Convert.ToInt32(MoneyType.Text)));
            MyDataGrid.ItemsSource = null;
            MyDataGrid.ItemsSource = objects;
            NameType.Text = null;
            MoneyType.Text = null;

        }
        private void MyDataGrid_SelectionChanger(object sender, SelectionChangedEventArgs e)
        {
            Type selected = MyDataGrid.SelectedItem as Type;
            MessageBox.Show($"Название: {selected.Name}. Стоимость: {selected.Money}");
        }
        

       public class Type
       {
            public string Name { get; set; }
            public string Info { get; set; }
            public int Money { get; set; }
            

            public Type (string name, string type, int money)
            {
                Name = name;
                Info = type;
                Money = money;
            }
       }
        
        private void DatePicker_SelectedDataChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(ExampleDtp.Text);
            MessageBox.Show(date.ToShortDateString());
            ExampleDtp.DisplayDateStart = new DateTime(2023, 03, 01);
            ExampleDtp.DisplayDateEnd = new DateTime(2023, 03, 31);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           selected = GuitarBox.Items[GuitarBox.SelectedIndex] as string;
        }
        private void Add_type_Click(object sender, RoutedEventArgs e)
        {
            AddScreen addScreen = new AddScreen();
            addScreen.ShowDialog();
            Guitar.Add(addScreen.Empty);
            GuitarBox.ItemsSource = null;
            GuitarBox.ItemsSource = Guitar;

        }
        private void Delete_objects_Click(object sender, RoutedEventArgs e)
        {
            objects.Clear();
            MyDataGrid.ItemsSource = null;
            MyDataGrid.ItemsSource = objects;
        }
    }
}