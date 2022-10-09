﻿using NotepadPlusPlusPlus.ViewModel;
using System.Windows;

/* 
 * To publish as single file, use 
 * dotnet publish -c Release -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true --output "./bin/publish"
 */

// TODO: Implement custom right click

namespace NotepadPlusPlusPlus
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ICloseWindow closeWindow)
            {
                closeWindow.Close += () => Close();

                Closing += (s, e) => e.Cancel = !closeWindow.CanClose();
            }
        }
    }
}
