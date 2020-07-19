using ProjectShopit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectShopit.Views
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            SplashScreen splashScreen = new SplashScreen("Models/SplashScreen1.png");
            splashScreen.Close(new TimeSpan(2000));
            Thread.Sleep(3000);

            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginClass login = new LoginClass();
            if(login.LoginDone(UBox.Text, PBox.Password))
            {
                MainWindow main = new MainWindow();
                this.Close();
                main.Show();
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
        
}
