using BCSCH2_Semestralni_Prace.ViewModel;
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

namespace BCSCH2_Semestralni_Prace.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModelOrganizator viewModelOrganizator;

        public MainWindow()
        {
            InitializeComponent();
            
            MainGrid.Children.Clear();
            MainGrid.Children.Add(MainPage);
        }

        private void LoginBtt_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(UserPage);

            viewModelOrganizator = new ViewModelOrganizator(UsernameBox.Text, PasswordBox.Text);
            this.DataContext = viewModelOrganizator;
        }

        private void RegistrationBtt_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(RegistrationPage);

            viewModelOrganizator = new ViewModelOrganizator();
            this.DataContext = viewModelOrganizator;
        }

        private void RegisterBtt_Click(object sender, RoutedEventArgs e)
        {
            viewModelOrganizator.Save();

            MainGrid.Children.Clear();
            MainGrid.Children.Add(MainPage);
        }
    }
}
