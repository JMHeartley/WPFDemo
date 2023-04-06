using System;
using System.Windows;
using System.Windows.Media;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _random;

        public MainWindow()
        {
            InitializeComponent();
            _random = new Random();
        }

        private byte[] GetArrayOfRandomBytes(int numberOfBytes)
        {
            var randomBytes = new byte[numberOfBytes];
            _random.NextBytes(randomBytes);
            return randomBytes;
        }

        private void SayHelloButton_Click(object sender, RoutedEventArgs e)
        {
            var randomBytes = GetArrayOfRandomBytes(3);

            var randomBrushColor = new SolidColorBrush(
                Color.FromArgb(255, randomBytes[0], randomBytes[1], randomBytes[2]));

            textBox1.BorderBrush = randomBrushColor;
            textBox1.Foreground = randomBrushColor;
        }
    }
}
