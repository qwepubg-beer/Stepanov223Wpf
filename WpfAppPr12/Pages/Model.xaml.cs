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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static WpfAppPr12.Cars;
 
namespace WpfAppPr12.Pages
{
    /// <summary>
    /// Логика взаимодействия для Model.xaml
    /// </summary>
    public partial class Model : Window
    {
        static List <string> CarModelEl=new List<string> { "Tesla Model Y", "Tesla Model 3", "BYD Song Plus EV" };
        static List<string> CarModelDz = new List<string> { "Ford F - Series Super Duty","Toyota Hilux","Ram 1500 EcoDiesel" };
        static List<string> CarModelBz = new List<string> { "Toyota RAV4", "Ford F-Series", "Toyota Corolla" };
        static List<string> MotorModel = new List<string> { "D","B","E"};
        static Cars car1 = new Cars("Tesla Model Y", 'E', 7375000);
        static Cars car2 = new Cars("Tesla Model 3", 'E', 5717500);
        static Cars car3 = new Cars("Tesla Model 3", 'E', 1810000);
        static Cars car4 = new Cars("Toyota RAV4", 'D', 6291013);
        static Cars car5 = new Cars("Toyota Hilux", 'D',7150000);
        static Cars car6 = new Cars("Ram 1500 EcoDiesel", 'B', 10500000);
        static Cars car7 = new Cars("Ford F - Series Super Duty", 'D', 10000000);
        static Cars car8 = new Cars("Ford F - Series", 'B', 9000000);
        static Cars car9 = new Cars("Ford F - Series Super Duty", 'B', 2000000);
        public Model()
        {
            InitializeComponent();
            List<Cars> cars = new List<Cars> {car1,car2,car3,car4,car5,car6,car7,car8, car9 };
            CarsComboBox.ItemsSource = cars;
            CarsComboBox.DisplayMemberPath = "Name";
            CarsComboBox.SelectedIndex = 1;
        }
    }
}
