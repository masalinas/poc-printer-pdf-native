using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PrinterPoCNative
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Server Printer PoC
        private string _serverPrinterUrl = "http://localhost:5173";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void GoToProxy_Click(object sender, RoutedEventArgs e)
        {
            this.icsWebBrowserView.Source = new Uri(_serverPrinterUrl);
        }
    }
}