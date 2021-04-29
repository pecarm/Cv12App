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

namespace Cv12App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client sluzba= new ServiceReference1.Service1Client();

            labelVysledek.Content = sluzba.Spocti(Convert.ToDecimal(textBoxOp1.Text), Convert.ToDecimal(textBoxOp2.Text), dropDownOperator.SelectedValue.ToString());
        }
    }
}
