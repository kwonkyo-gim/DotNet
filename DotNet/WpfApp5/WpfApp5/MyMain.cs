﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp5
{
    class MyMain : Application
    {
        [STAThread]
        public static void Main()
        {
            MyMain app = new MyMain();
            app.Run();

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();

            for (int i = 0; i < 2; i++) 
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.Show();
            }


            void WinMouseDown(object sender, MouseEventArgs args)
            {
                Window win = new Window();
                win.Title = "Modal DialogBox";
                win.Width = 400;
                win.Height = 200;


                Button b = new Button();
                b.Content = "Click Me!";
                b.Click += Button_Click;

                win.Content = b;
                win.ShowDialog();



            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
