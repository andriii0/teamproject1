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
                    if (user.Username == "admin" && user.Password == "admin")
                    {
                        isAdmin = true;
                        break;
                    }
                    else
                    {
                        isAuthenticated = true;
                        roomNumber = user.Room;
                        break;
                    }
                }
            }

            if (isAuthenticated)
            {
                CurrentUser.StudentName = username;
                CurrentUser.RoomNumber = roomNumber;
                Rules rules = new Rules();
                this.Hide();
                rules.Show();
            }
            else if (isAdmin)
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Something is wrong! :/");
            }
        }

        private UserDatabase LoadUsersFromJson()
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<UserDatabase>(jsonText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading file: " + ex.Message);
                return new UserDatabase { Users = new List<User>() };
            }
        }
    }
}
