using ProjectShopit.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectShopit.Models
{
    public class LoginClass
    {
        public string userName { get; set; }
        public string passwordText { get; set; }

        public bool isLogin { get; set; } = false;

        public bool LoginDone(string uString,string pString)
        {
           this.userName = uString.Trim();
           this.passwordText = pString.Trim();
           
            if(userName != String.Empty && passwordText != String.Empty)
            {
                if(userName == "ben" && passwordText == "united")
                {
                    MessageBox.Show("Wilkommen");
                    isLogin = true;                }
                else
                {
                    MessageBox.Show("Benutzername und Passwort stimmen nicht überein");
                    isLogin = false;
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie etwas ein");
                isLogin = false;
            }

            return isLogin;
        }
    }



}
