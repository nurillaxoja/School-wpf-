﻿using System;
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
using School.dbHelper;

namespace School.Pages
{
    /// <summary>
    /// Interaction logic for Marks.xaml
    /// </summary>
    public partial class Marks : Page
    {
        public Marks()
        {
            InitializeComponent();
            dateGrid.ItemsSource = SchoolClassHelper.GetClasses();
        }
    }
}
