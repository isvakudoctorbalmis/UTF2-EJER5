
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media;

namespace UTF2_EJER5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked =true;
        }

     

        private void textoTextBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            string texto = textoTextBlock.Text.ToString();

            cuadroTextBlock.Text = texto;
          
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.FontWeight= FontWeights.Bold;    
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.FontWeight = FontWeights.Regular;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.FontStyle = FontStyles.Italic;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.Foreground= Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.Foreground = Brushes.Green;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            cuadroTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
