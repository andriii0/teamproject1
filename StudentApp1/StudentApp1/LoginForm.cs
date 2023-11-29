using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace StudentApp1
{
    public partial class LoginForm : Form
    {
        private readonly string filePath = "C:\\Users\\Yuri\\source\\repos\\StudentApp1\\StudentApp1\\students.json";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text; 
            string password = passwordTextBox.Text; 

            List<Student> students = LoadStudentsFromJson();

            bool isAuthenticated = false;

            foreach (Student student in students)
            {
                if (student.Email == username && student.Password == password)
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                MessageBox.Show("Succesful!");
                Form1 form1 = new Form1();  
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Something is wrong! :/");
            }
        }

        private List<Student> LoadStudentsFromJson()
        {
            try
            {
                string jsonText = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), filePath));
                return JsonConvert.DeserializeObject<List<Student>>(jsonText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong with reading file: " + ex.Message);
                return new List<Student>();
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
