using Api.Controllers;
using Api.ViewModel;
using LolRank.View;
using System.Windows;


namespace Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ControllerMain controller;
        ViewModelMain viewModelMain;
        public MainWindow()
        {
            controller = new ControllerMain();
            viewModelMain = new ViewModelMain();
            InitializeComponent();

            this.DataContext = viewModelMain;
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(viewModelMain.Region))
            {
                return;
            }
            if (string.IsNullOrEmpty(viewModelMain.SummonerName))
            {
                WindowProfile profile = new WindowProfile();
                profile.Show();
                this.Close();
            }

            if (controller.GetSummoner(viewModelMain.Region, viewModelMain.SummonerName))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
