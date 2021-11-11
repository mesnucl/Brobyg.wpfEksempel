
using System.Windows;
using System.Windows.Media;

namespace WPFBROBRYG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonToClick.Click += buttonClick;

        }
        public void buttonClick(object sender, RoutedEventArgs e){

            ButtonToClick.Background = new SolidColorBrush(Colors.Red);

            LabelResult.Background = new SolidColorBrush(Colors.Red);
            LabelResult.Content = "You Clicked the Button!";
        }

        
    }
}
