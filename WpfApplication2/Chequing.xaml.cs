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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Chequing.xaml
    /// </summary>
    public partial class Chequing : Page
    {
        public static int balance, saving, chequing;
        public static bool show = false;
        public Chequing()
        {
            InitializeComponent();

            balance = MainWindow.balance;
            saving = MainWindow.saving;
            chequing = MainWindow.chequing;
            show = false;

            updatetext();

        }

        private void updatetext()
        {
            if (show)
                textBlock.Text = String.Concat("$ ", chequing.ToString());
            else
                textBlock.Text = "HIDDEN";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void Click20(object sender, RoutedEventArgs e)
        {
            if (chequing >= 20)
            {
                chequing -= 20;
                balance -= 20;
                status.Content = "Withdrawed $20 from Savings";
            }
            else
                status.Content = "Insufficient Funds";

            updatetext();
        }

        private void insufficientfunds()
        {
            throw new NotImplementedException();
        }

        private void Click40(object sender, RoutedEventArgs e)
        {
            if (chequing >= 40)
            {
                chequing -= 40;
                balance -= 40;
                status.Content = "Withdrawed $40 from Savings";
            }
            else
                status.Content = "Insufficient Funds";

            updatetext();
        }

        private void Click60(object sender, RoutedEventArgs e)
        {
            if (chequing >= 60)
            {
                chequing -= 60;
                balance -= 60;
                status.Content = "Withdrawed $60 from Savings";
            }
            else
                status.Content = "Insufficient Funds";

            updatetext();
        }

        private void Clcik80(object sender, RoutedEventArgs e)
        {
            if (chequing >= 80)
            {
                chequing -= 80;
                balance -= 80;
                status.Content = "Withdrawed $80 from Savings";
            }
            else
                status.Content = "Insufficient Funds";

            updatetext();
        }

        private void Click100(object sender, RoutedEventArgs e)
        {
            if (chequing >= 100)
            {
                chequing -= 100;
                balance -= 100;
                status.Content = "Withdrawed $100 from Savings";
            }
            else
                status.Content = "Insufficient Funds";
            updatetext();
        }

        private void customclick(object sender, RoutedEventArgs e)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                if (chequing >= value)
                {
                    chequing -= value;
                    balance -= value;
                    //String temp = String.Concat("Withdrawed $", ;
                    status.Content = "Withdrawed $" + textBox.Text + " from Savings";
                }
                else
                    status.Content = "Insufficient Funds";
                //parsing successful 
            }
            else
            {
                status.Content = "Please enter an amount";
                //parsing failed. 
            }
            updatetext();
        }

        private void showhide(object sender, RoutedEventArgs e)
        {
            show = !show;
            if (show)
                updatetext();
            else
                textBlock.Text = "HIDDEN";
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            //tb.GotFocus -= textBox_GotFocus;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.balance = balance;
            MainWindow.saving = saving;
            MainWindow.chequing = chequing;
            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }
    }
}