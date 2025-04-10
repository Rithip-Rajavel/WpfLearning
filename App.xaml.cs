using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfLearning;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        MainWindow main = new MainWindow();
        if (e.Args.Length == 1)
        {
            MessageBox.Show("Now Opening File: \n\n" + e.Args[0]);
        }
        main.Show();
    }
}

