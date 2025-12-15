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
using static WpfAppPr12.Options;

namespace WpfAppPr12.Pages
{
    /// <summary>
    /// Логика взаимодействия для Color1.xaml
    /// </summary>
    public partial class Color1 : Page
    {
        static public List<string> Colors = new List<string> { "Чёрный", "Белый", "Синий", "Желтый", "Красный", "Серебристый" };
        static Options O1 = new Options("Подогрев жопы", 20000);
        static Options O2 = new Options("Видиорегистратор", 15000);
        static Options O3 = new Options("Магнитола", 20000);
        static Options O4 = new Options("Багажник на крышу", 20000);
        static Options O5 = new Options("Подпись Перминова", 100000);
        public Color1()
        {
            InitializeComponent();
            ColorComboBox.ItemsSource = Colors;
            ColorComboBox.SelectedIndex = 1;
        }
        public double CountCost()
        {
            double count = 0;
            if (Jp.IsChecked == true) count += O1.price;
            if (Vr.IsChecked == true) count += O2.price;
            if (Mg.IsChecked == true) count += O3.price;
            if (BK.IsChecked == true) count += O4.price;
            if (AP.IsChecked == true) count += O5.price;
            return count;
        }
    }
}

