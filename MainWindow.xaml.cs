using System;
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
//    private void btnClick_Click(object sender, RoutedEventArgs e)
//     {
//         try
//         {
//             lbResult.Items.Add(pnlMain.FindResource("strPanel")?.ToString());
//             lbResult.Items.Add(this.FindResource("strWindow")?.ToString());
//             lbResult.Items.Add(Application.Current.FindResource("strApp")?.ToString());
//         }
//         catch (ResourceReferenceKeyNotFoundException ex)
//         {
//             lbResult.Items.Add($"Missing resource: {ex.Key}");
//         }
//     }

}