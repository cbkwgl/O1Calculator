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

namespace O1Calculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int first = Int32.Parse(txbFirstNum.Text);
            int second = Int32.Parse(txbSecondNum.Text);
            lblResult_Sum.Content = "Sum = " + (first + second);
            lblResult_Difference.Content = "Difference = " + (second - first);
            lblResult_Product.Content = "Product = " + (first * second);
            lblResult_Division.Content = "Quotient = " + (second / first);



        }
    }
}
