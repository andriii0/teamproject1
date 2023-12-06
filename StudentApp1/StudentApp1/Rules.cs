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
    public partial class Rules : Form
    {
        private string StudentName;

        public Rules(string studentName)
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1(StudentName);
            form1.Show();
        }
    }

}
