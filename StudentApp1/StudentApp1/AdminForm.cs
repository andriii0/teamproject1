﻿using System;
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
        private const string jsonFilePath = "C:\\Users\\Yuri\\source\\repos\\StudentApp1\\StudentApp1\\users.json";
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
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class UserDatabase
        {
            public List<User> Users { get; set; }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create a new user based on form inputs
            User newUser = new User
            {
                Id = userDatabase.Users.Count, // Assign unique ID
                Name = textBox1.Text,
                Username = textBox2.Text,
                Age = int.Parse(textBox3.Text), // Assuming the age input is valid
                Email = textBox4.Text,
                Password = textBox5.Text
            };

            // Add the new user to the user list
            userDatabase.Users.Add(newUser);

            // Save the updated user list to the JSON file
            SaveUserData();

            MessageBox.Show("Пользователь успешно добавлен!");

        }

    }
}
