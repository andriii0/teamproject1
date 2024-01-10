using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class ToDoForm : Form
    {
        private User authenticatedUser;

        public ToDoForm(User user)
        {
            InitializeComponent();

            if (user != null && user.Tasks != null)
            {
                authenticatedUser = user;
                DisplayTasks();
            }
            else
            {
                MessageBox.Show("User information is null.");
                this.Close();
            }
        }



        private void DisplayTasks()
        {
            if (authenticatedUser != null && authenticatedUser.Tasks != null)
            {
                foreach (Task task in authenticatedUser.Tasks)
                {
                    if (task != null && task != null)
                    {
                        string taskInfo = $"{task.GetTaskId()}, {task.GetTasks()}, {task.GetDescription()}, {task.GetDateTime():yyyy-MM-dd}, {authenticatedUser.Name}";

                        listBoxTasks.Items.Add(taskInfo);
                    }
                }
            }
            else
            {
                MessageBox.Show("User information or tasks are null.");
                this.Close();
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1(authenticatedUser);
            form1.Show();
        }
    }
}
