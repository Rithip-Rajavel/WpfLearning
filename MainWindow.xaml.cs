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

namespace WpfLearning;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    // private void Button_Click(object sender, RoutedEventArgs e)
    // {
    //     string text = InputTextBox.Text;
    //     MessageBox.Show($"You entered: {text}");
    // }
    private void MainGrid_MouseUp(Object sender,MouseButtonEventArgs e)
    {
        
        // if (e.ChangedButton == MouseButton.Left)
        // {
        //     MessageBox.Show("Left mouse button clicked!");
        // }
        // else if (e.ChangedButton == MouseButton.Right)
        // {
        //     MessageBox.Show("Right mouse button clicked!");
        // }

        MessageBox.Show("You Clicked me at"+e.GetPosition(this).ToString());
    }

}