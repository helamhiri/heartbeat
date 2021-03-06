﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace heartbeat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class doc : Page
    {
        public doc()
        {
            this.InitializeComponent();
        }

        private void book1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(profile));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(listen));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(newforum));
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(inspire));
        }

        private void talk2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(doctalk));
        }

        private void talk1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(doctalk));
        }
    }
}
