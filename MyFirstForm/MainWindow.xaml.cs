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

namespace MyFirstForm
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonToSumNumbers_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberInput.Text);
            int secondNumber = Convert.ToInt32(secondNumberInput.Text);
            int result = firstNumber + secondNumber;
            resultOutput.Content = result.ToString();
        }

        private void ButtonToDivideNumbers_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberInput.Text);
            int secondNumber = Convert.ToInt32(secondNumberInput.Text);
            double result = Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber);
            resultOutput.Content = result.ToString();
        }

        private void ButtonToSubtractNumbers_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberInput.Text);
            int secondNumber = Convert.ToInt32(secondNumberInput.Text);
            int result = firstNumber - secondNumber;
            resultOutput.Content = result.ToString();
        }

        private void ButtonToMultiplyNumbers_Click(object sender, RoutedEventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberInput.Text);
            int secondNumber = Convert.ToInt32(secondNumberInput.Text);
            int result = firstNumber * secondNumber;
            resultOutput.Content = result.ToString();
        }
    }
}
