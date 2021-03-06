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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace hamburgerExample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigationRoot : Page
    {
        public NavigationRoot()
        {
            this.InitializeComponent();
            Content.Navigate(typeof(SummaryPage));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e) => MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

        private void MenuButton1_Click(object sender, RoutedEventArgs e) => Content.Navigate(typeof(SummaryPage));

        private void MenuButton2_Click(object sender, RoutedEventArgs e) => Content.Navigate(typeof(page2));

        private void MenuButton3_Click(object sender, RoutedEventArgs e) => Content.Navigate(typeof(page3));
    }
}
