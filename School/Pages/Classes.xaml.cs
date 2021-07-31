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
using School.MainView;
using School.dbHelper;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Classes.xaml
    /// </summary>
    public partial class Classes : Page
    {

        public Classes()
        {
            InitializeComponent();
        }
        Logger lg = new Logger();
        private void btnClass1_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(1);
            this.NavigationService.Navigate(new StudentsMark());
        }

        private void btnClass2_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(2);
            this.NavigationService.Navigate(new StudentsMark());
        }

        private void btnClass3_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(3);
            this.NavigationService.Navigate(new StudentsMark());
        }

        private void btnClass4_Click(object sender, RoutedEventArgs e)
        {
            lg.WriteEnterSheadule(4);
            this.NavigationService.Navigate(new StudentsMark());
        }
        public int getValue()
        {
            return 1;
        }
    }
}