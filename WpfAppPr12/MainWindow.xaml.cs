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
using WpfAppPr12.Pages;
using static WpfAppPr12.OurCar;

namespace WpfAppPr12
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new Main());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void GoBack1_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService?.CanGoBack == true)
            {
                MainFrame.NavigationService.GoBack();
            }
        }

        private void ModelWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Model());
        }

        private void ColorWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Color1());
        }

        private void EndWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Result());
        }

        private void CreditWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Credit());
        }

        private void ZayavkaWindow_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Order());
        }
    }
    
}
