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

namespace Miniräknare
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
        public void OkButton_Klick(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                Text1.Text += button.Content;
            }
            
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            
            if (Text1.Text.Contains("+"))
            {
                Text1.Text = Addition();
            }

            else if (Text1.Text.Contains("-"))
            {
                Text1.Text = Subtraction();
            }
            else if (Text1.Text.Contains("x"))
            {
                Text1.Text = Multiplication();
            }
            else if (Text1.Text.Contains("/"))
            {
                Text1.Text = Division();
            }
            else if (Text1.Text.Contains("²"))
            {
                Text1.Text = Squared();
            }
            else if (Text1.Text.Contains("√"))
            {
                Text1.Text = SquareRoot();
            }
        }
        private string Addition()
        {
            var numbers = Text1.Text.Split("+");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 + number2;
            return sum + "";
        }
        private string Subtraction()
        {
            var numbers = Text1.Text.Split("-");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 - number2;
            return sum + "";
        }
        private string Multiplication()
        {
            var numbers = Text1.Text.Split("x");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 * number2;
            return sum + "";
        }
        private string Division()
        {
            var numbers = Text1.Text.Split("/");
            var number1 = Convert.ToDouble(numbers[0]);
            var number2 = Convert.ToDouble(numbers[1]);
            var sum = number1 / number2;
            return sum + "";
        }
        private void Clear(Object sender, RoutedEventArgs e)
        {

            Text1.Text = "";
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            if (Text1.Text.Length < 1)
            {
                Text1.Text = "";
            }
            else
            {
                Text1.Text = Text1.Text.Remove(Text1.Text.Length - 1);
            }
        }
        private string Squared()
        {
            var numbers = Text1.Text.Split("²");
            var number1 = Convert.ToDouble(numbers[0]);
            var sum = Math.Pow(number1, 2);
            return sum + "";
        }
        private string SquareRoot()
        {
            var number2 = 0.0;
            var numbers = Text1.Text.Split("√");
            if (numbers[1] == "")
            {
                
            }
            else
            {
                number2 = Convert.ToDouble(numbers[1]);
            }



            var sum = Math.Sqrt(number2);
            return sum + "";
        }
    }
    }