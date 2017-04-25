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
    public sealed partial class talkingpro : Page
    {
        public talkingpro()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
                tweeti.Text =  e.Parameter.ToString();
           
           
            base.OnNavigatedTo(e);
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
            this.Frame.Navigate(typeof(doc));
        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(inspire));
        }
    }
}