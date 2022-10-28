using Api.Controllers;
using LolRank.View;
using LolRank.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
