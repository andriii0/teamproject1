using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;



namespace StudentApp1
{
    public partial class AdminForm : Form
    {
        private const string jsonFilePath = "users.json";
        private UserDatabase userDatabase;

        public AdminForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                userDatabase = JsonConvert.DeserializeObject<UserDatabase>(json);
            }
            else
            {
                userDatabase = new UserDatabase { Users = new List<User>() };
            }
        }

        private void SaveUserData()
        {
            string json = JsonConvert.SerializeObject(userDatabase);
            File.WriteAllText(jsonFilePath, json);
        }

        private void LogOut()
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void LogOutLabel1_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOutLabel2_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public int Age { get; set; }
            public int Room { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class UserDatabase
        {
            public List<User> Users { get; set; }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a new user based on form inputs
            User newUser = new User
            {
                Id = userDatabase.Users.Count,
                Name = textBox1.Text,
                Username = textBox2.Text,
                Age = int.Parse(textBox3.Text),
                Email = textBox4.Text,
                Password = textBox5.Text,
                Room = int.Parse(textBox6.Text)
            };

            userDatabase.Users.Add(newUser);
            SaveUserData();

            MessageBox.Show("User has been added!");

        }
    }
}
