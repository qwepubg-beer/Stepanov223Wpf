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
        static List<string> MotorModel = new List<string> { "Дизель","Бензин","Электро"};
        public Model()
        {
            InitializeComponent();
        }
    }
}
