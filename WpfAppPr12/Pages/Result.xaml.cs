using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfAppPr12.Pages
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        static public List<string> Colors = new List<string> { "Наличными", "Картой", "Наличными и картой", };
        public Result()
        {
            InitializeComponent();
            PayType.ItemsSource = Colors;
            PayType.SelectedIndex = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool G = Name.Text.Length > 0 && Oname.Text.Length > 0 && LastName.Text.Length > 0;
            if (!G) MessageBox.Show("Введите ФИО");
            else if (!Email.Text.Contains('@')) MessageBox.Show("Введите почту");
            else
            {
                MessageBox.Show("Спасибо за заказ!");
            }
        }
    }
}
