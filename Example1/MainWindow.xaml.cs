﻿using System.Windows;
using System.Windows.Media;

namespace Example1
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
            this.Resources["PrimaryBrush"]=new SolidColorBrush(Colors.Blue);
        }
    }
}