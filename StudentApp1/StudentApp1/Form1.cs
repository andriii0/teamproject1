namespace StudentApp1
{
    public partial class Form1 : Form
    {
        string StudentName = "";

        public Form1()
        {
            InitializeComponent();
            UpdateHelloText();
        }

        private void UpdateHelloText()
        {
            HelloText.Text = $"Hello! {CurrentUser.StudentName} :)";
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
            Rules rules = new Rules();
            rules.Show();
        }
        private void Notes_Click(object sender, EventArgs e)
        {
            NoteDisplayForm noteDisplayForm = new NoteDisplayForm();
            this.Close();
            noteDisplayForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Complaints_Click(object sender, EventArgs e)
        {
            Complaints complaints = new Complaints();
            this.Close();
            complaints.Show();
        }
    }
}