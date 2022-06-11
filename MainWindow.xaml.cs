using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultText.Text = string.Empty;
            CurrentOperationText.Text = string.Empty;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = string.Empty;

            var button = sender as Button;

            var currentNumber = button.Name[button.Name.Length-1];

            CurrentOperationText.Text += currentNumber;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperationText.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperationText.Text += "-";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperationText.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            CurrentOperationText.Text += "/";
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
