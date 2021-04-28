using Microsoft.UI.Xaml;
using System;
using Microsoft.UI.Xaml.Controls;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CheckMySalaryV2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainViewModel ViewModel { get; }

        public MainWindow()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();
        }

        private async void ShowMsgBox_Click(object sender, RoutedEventArgs e)
        {
            if (_datagrid != null)
            {

                var cd = new ContentDialog
                {
                    Title = "Button Clicker!",
                    Content = "You clicked the button!",
                    CloseButtonText = "Ok"
                };

                cd.XamlRoot = this.Content.XamlRoot;


                try
                {
                    var result = await cd.ShowAsync();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }
}
