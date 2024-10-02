using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFfirst
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

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.classification.Source = null;
            this.destination.Source = null;
        }

        private void changeColor_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush Yellow = new SolidColorBrush(Colors.Yellow);
            SolidColorBrush YellowGreen = new SolidColorBrush(Colors.YellowGreen);
            if (this.Line.Background.ToString() == "#FF9ACD32")
            {
                this.Line.Background = Yellow;
            }
            else 
            {
                this.Line.Background = YellowGreen;
            }
        }

        private void changeClassification_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog classification = new OpenFileDialog();
            bool? DialogResult = classification.ShowDialog();
            if (DialogResult == true) {
                Uri uri = new Uri(classification.FileName);
                BitmapImage bmp = new BitmapImage(uri);
                this.classification.Source = bmp;
            }
        }

        private void changeDirection_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog destination = new OpenFileDialog();
            bool? DialogResult = destination.ShowDialog();
            if (DialogResult == true)
            {
                Uri uri = new Uri(destination.FileName);
                BitmapImage bmp = new BitmapImage(uri);
                this.destination.Source = bmp;
            }
        }
    }
}