namespace StudentApp1
{
    public partial class Form1 : Form
    {
        string StudentName = "";

        public Form1(string studentName)
        {
            InitializeComponent();
            StudentName = studentName;
            UpdateHelloText();
        }

        private void UpdateHelloText()
        {
            HelloText.Text = $"Hello! {StudentName} :)";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            this.Close();
            loginForm.Show();
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rules rules = new Rules(StudentName);
            rules.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelloText.Text = $"Hello! {StudentName} :)";
        }
    }
}