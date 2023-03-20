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

namespace _4_prakt.wpf
{
    /// <summary>
    /// Логика взаимодействия для AddScreen.xaml
    /// </summary>
    public partial class AddScreen : Window
    {
        public string Empty;
        
        public AddScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Empty = AddInfo.Text;
            Close();

        }
    }
}
