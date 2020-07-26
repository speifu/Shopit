using System;
using System.Linq;
using System.Windows;

namespace ProjectShopit.Models
{
    public class LoginClass
    {
        SqlConnection sqlConnection;
        public LoginWindow()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProjectShopit.Properties.Settings.benearthConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        public void GetUserData()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Benutzer where UserName=@userName and UserPassword =@userPassword", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userName", UBox.Text);
                sqlCommand.Parameters.AddWithValue("@userPassword", PBox.Password);
                Console.WriteLine(PBox.Password);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                sqlConnection.Close();
                int count = dataSet.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login hat geklappt");
                }
                else
                {
                    MessageBox.Show($"Login hat nicht geklappt. Der Nutzer name {UBox.Text} und das PW {PBox.Password}");
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
    }
}
