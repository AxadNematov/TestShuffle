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

namespace TestAppLogIn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToSecondWindow(object sender, RoutedEventArgs e)
        {
            string loginMail = mail.Text;
            string loginPassword = password.Password;

            // here we should check if mail and password correct and allow user to go to second window
            
            Window1 secondWindow = new Window1();
            this.Visibility = Visibility.Hidden;
            secondWindow.personMail.Text = mail.Text;
            secondWindow.Show();
        }
    }
}
