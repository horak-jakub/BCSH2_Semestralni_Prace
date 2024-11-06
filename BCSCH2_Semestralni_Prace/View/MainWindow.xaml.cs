using BCSCH2_Semestralni_Prace.Services;
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
        LiteDBManager liteDBManager;
        ViewModelOsoba viewModelOsoba;

        public MainWindow()
        {
            InitializeComponent();
            
            MainGrid.Children.Clear();
            MainGrid.Children.Add(MainPage);

            liteDBManager = new LiteDBManager();
        }

        private void LoginBtt_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(UserPage);

            var viewModelOsoba = liteDBManager.LoadOsoba(UsernameBox.Text, PasswordBox.Text);
            this.DataContext = viewModelOsoba;
        }

        private void RegistrationBtt_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(RegistrationPage);

            viewModelOsoba = new ViewModelOsoba();
            this.DataContext = viewModelOsoba;
        }

        private void RegisterBtt_Click(object sender, RoutedEventArgs e)
        {
            liteDBManager.SaveOsoba(viewModelOsoba);
        }
    }
}
