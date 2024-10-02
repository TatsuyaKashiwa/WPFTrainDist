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

        //閉じるボタン(アプリケーションを閉じる)
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //表示取消ボタン(選択した画像の表示を取り消す)
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.classification.Source = null;
            this.destination.Source = null;
        }

        //帯色変更ボタン(帯色(表示域最上部の背景色)を黄緑/黄色に切り替える)
        private void changeColor_Click(object sender, RoutedEventArgs e)
        {
            if (this.Line.Background.ToString() == "#FF9ACD32")
            {
                this.Line.Background = new SolidColorBrush(Colors.Yellow); ;
            }
            else 
            {
                this.Line.Background = new SolidColorBrush(Colors.YellowGreen);
            }
        }

        //種別変更ボタン(左側表示領域に選択した画像を表示)
        //プロジェクト内classificationフォルダの絶対パスをInitialDirectoryに指定してください
        private void changeClassification_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog classification = new OpenFileDialog();
            classification.Title = "行先選択";
            classification.InitialDirectory = "";
            bool? DialogResult = classification.ShowDialog();
            if (DialogResult == true) {
                Uri uri = new Uri(classification.FileName);
                BitmapImage bmp = new BitmapImage(uri);
                this.classification.Source = bmp;
            }
        }

        //行先変更ボタン(左側表示領域に選択した画像を表示)
        //プロジェクト内destinationフォルダの絶対パスをInitialDirectoryに指定してください
        private void changeDirection_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog destination = new OpenFileDialog();
            destination.Title = "行先表示";
            destination.InitialDirectory = "";
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