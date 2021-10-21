using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaStyles = Avalonia.Styling.Styles;
using Avalonia.Markup.Xaml.Styling;
using MessageBox.Avalonia;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;
using Microsoft.VisualBasic;
using ReactiveUI;
using Style = Avalonia.Styling.Style;

namespace ExportProduktkategorien.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager
                .GetMessageBoxStandardWindow("title", "Hallo");
            messageBoxStandardWindow.ShowDialog(this);
        }

        private void ThemeToggle_OnClick(object? sender, RoutedEventArgs e)
        {
        }
        
    }
}