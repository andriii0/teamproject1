using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using static StudentApp1.AdminForm;

namespace StudentApp1
{
    public partial class LoginForm : Form
    {
        private readonly string filePath = "users.json";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            UserDatabase userDatabase = LoadUsersFromJson();

            bool isAuthenticated = false;
            bool isAdmin = false;
            int roomNumber = 0;

            foreach (User user in userDatabase.Users)
            {
                if ((user.Username == username && user.Password == password) || (user.Email == username && user.Password == password))
                {
                    isAuthenticated = true;
                    CurrentUser.LoggedInUser = user;

                    if (user.Username == "admin" && user.Password == "admin")
                    {
                        isAdmin = true;
                        break;
                    }
                }
            }

            if (isAuthenticated)
            {
                User authenticatedUser = CurrentUser.LoggedInUser;

                if (!isAdmin)
                {
                    Form1 form1 = new Form1(authenticatedUser);
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
            }
            else MessageBox.Show("Error logging in");
        }

        private UserDatabase LoadUsersFromJson()
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);
                UserDatabase userDatabase = JsonConvert.DeserializeObject<UserDatabase>(jsonText);

                if (userDatabase != null && userDatabase.Users != null)
                {
                    return userDatabase;
                }
                else
                {
                    return new UserDatabase { Users = new List<User>() };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading file: " + ex.Message);
                return new UserDatabase { Users = new List<User>() };
            }
        }
    }
}
