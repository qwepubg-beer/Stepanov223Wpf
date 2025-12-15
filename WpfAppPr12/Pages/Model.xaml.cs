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
using static WpfAppPr12.Cars;

namespace WpfAppPr12.Pages
{
    /// <summary>
    /// Логика взаимодействия для Model.xaml
    /// </summary>
    public partial class Model : Page
    {
        static Cars car1 = new Cars("Tesla Model Y", 'E', 7375000);
        static Cars car2 = new Cars("Tesla Model 3", 'E', 5717500);
        static Cars car4 = new Cars("Toyota RAV4", 'B', 6291013);
        static Cars car5 = new Cars("Toyota Hilux", 'B', 7150000);
        static Cars car6 = new Cars("Ram 1500 EcoDiesel", 'B', 10500000);
        static Cars car7 = new Cars("Ford F - Series Super Duty", 'D', 10000000);
        static Cars car8 = new Cars("Ford F - Series", 'D', 9000000);
        
        public Model()
        {
            InitializeComponent();
            switch(OurCar.TypeCar)
            {
                case 'B': B.IsChecked = true;break;
                case 'D': D.IsChecked = true; break;
                default: E.IsChecked = true; break;
            }
            List<string> carsE = new List<string> { car1.CarName, car2.CarName, car7.CarName, car8.CarName, car4.CarName, car5.CarName, car6.CarName };
            CarsComboBox.ItemsSource = carsE;
            CarsComboBox.SelectedIndex = 1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Content.ToString())
            {
                case "Электромобиль":
                    OurCar.TypeCar = 'E';
                    
                    break;
                case "Дизель":
                    OurCar.TypeCar = 'D';
                    
                    break;
                case "Бензин":
                    OurCar.TypeCar = 'B';
                    
                    break;
            }
        }

        private void CarsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CarsComboBox.SelectedItem)
            {
                case "Tesla Model Y":
                    OurCar.Car = car1;
                    break;
                case "Tesla Model 3":
                    OurCar.Car = car2;
                    break;
                case "Toyota RAV4":
                    OurCar.Car = car4;
                    break;
                case "Toyota Hilux":
                    OurCar.Car = car5;
                    break;
                case "Ram 1500 EcoDiesel":
                    OurCar.Car = car6;
                    break;
                case "Ford F - Series Super Duty":
                    OurCar.Car = car7;
                    break;
                case "Ford F - Series":
                    OurCar.Car = car8;
                    break;
            }
        }
    }
}
