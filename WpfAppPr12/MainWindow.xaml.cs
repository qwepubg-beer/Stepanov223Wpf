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
using static WpfAppPr12.Value;

namespace WpfAppPr12
{
    
    public partial class MainWindow : Window
    {
        List<Page> pages=new List<Page> {new Main(), new Model(),new Color1(), new End(), new Order(), new Result() };
        
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
            if(Value.T!=0)
                Value.T --;
            if (MainFrame.NavigationService?.CanGoBack == true)
            {
                
                MainFrame.NavigationService.GoBack();
            }
            else 
            {
                MainFrame.NavigationService.Navigate(pages[Value.T]);
            }
        }

        private void ModelWindow_Click(object sender, RoutedEventArgs e)
        {
            if (Value.T < 5) Value.T ++;
            if (MainFrame.NavigationService?.CanGoForward == true)
            {
                
                MainFrame.NavigationService.Navigate(pages[Value.T]);
            }
            else 
            {
                MainFrame.NavigationService.Navigate(pages[Value.T]);
            }
        }
    }
    
}
