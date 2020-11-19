using System;
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
                OkText.Text += button.Content;
            }
            
        }
        private void equal_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (Operation == )
            {

            }
        }
    }
}
