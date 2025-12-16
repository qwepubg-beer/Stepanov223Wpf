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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
            /*
            C - цена на авто
            P - первоначальный взнос
            S - сумма кредита
            r - годовая ставка
            n - срок в месяцах
            A - ежемесячный платеж
            i - месячная процентная ставка
            S=C−P
            i=r/12 ​// если r целое число, то i=r/100/12
            A = S*(i*(1+i)^n)/(1+i)^n - 1
            */

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int P;
            if (!int.TryParse(Vznos.Text, out P)) { MessageBox.Show("Введите правильный первоначальный взнос"); }
            int r;
            if (!int.TryParse(Stavka.Text, out r)) { MessageBox.Show("Введите правильную годовая ставка"); }
            int n;
            if ((!int.TryParse(Srok.Text, out n) || n<12)){ MessageBox.Show("Введите правильный срок в месяцах"); }
            var C = OurCar.Car.Price + OurCar.PriceColor + OurCar.PriceOptions;
            var S = C - P;
            double i = r / 100 / 12;
            double A = S * (i * Math.Pow((1 + i), n)) / (Math.Pow((1 + i), n) - 1);
            mes.Text = $"{A}";
            procent.Text = $"{i}";
        }
    }
}
