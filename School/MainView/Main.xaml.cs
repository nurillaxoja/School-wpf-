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
using School.Pages;

namespace School.MainView
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }
        Logger lg = new Logger();
        private void profileClick(object sender, RoutedEventArgs e)
        {
            lg.WriteProfile();
            MainFrame.NavigationService.Navigate(new profile());
        }

        private void classClick(object sender, RoutedEventArgs e)
        {
            lg.WriteClasses();
            MainFrame.NavigationService.Navigate(new Classes());
        }

        private void exitClick(object sender, RoutedEventArgs e)
        {
            lg.WriteExit();
            MainWindow.Close();
        }

        private void logClick(object sender, RoutedEventArgs e)
        {
            lg.WriteLogger();
            MainFrame.NavigationService.Navigate(new Log());
        }
        
    
    }
}
