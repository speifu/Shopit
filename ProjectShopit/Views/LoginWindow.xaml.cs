using System;
using System.Windows;

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
        }
    }  
}
