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

namespace WpfAppPr12.Pages
{
    /// <summary>
    /// Логика взаимодействия для End.xaml
    /// </summary>
    public partial class End : Page
    {
       
        public End()
        {
            InitializeComponent();
           
        }

         private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ах ты бедный еврей, не будет скидки!");
            Final.Text = $"{OurCar.Car.Price + OurCar.PriceColor + OurCar.PriceOptions} рублей";
        }
    }
}
