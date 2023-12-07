using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace StudentApp1
{
    public partial class NoteDisplayForm : Form
    {
        private string StudentName;
        private List<Note> notes;
        public NoteDisplayForm()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(StudentName);
            this.Close();
            form1.Show();
        }
        private void LoadNotes()
        {
            string jsonFilePath = Path.Combine(Application.StartupPath, "notes.json");

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                notes = JsonConvert.DeserializeObject<List<Note>>(json);
            }
            else
            {
                notes = new List<Note>();
            }

            DisplayNotes();
        }

        private void DisplayNotes()
        {
            tableLayoutPanel.Controls.Clear();

            foreach (Note note in notes)
            {
                Panel notePanel = CreateNotePanel(note);
                tableLayoutPanel.Controls.Add(notePanel);
            }
        }

        private Panel CreateNotePanel(Note note)
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.Fixed3D,
                Width = 200,
                Height = 150
            };

            Label authorLabel = new Label
            {
                Text = $"Author: {note.Author}",
                Dock = DockStyle.Bottom
            };

            TextBox contentTextBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = note.Content,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical
            };

            panel.Controls.Add(authorLabel);
            panel.Controls.Add(contentTextBox);

            return panel;
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNoteForm addNoteForm = new AddNoteForm();
            addNoteForm.Show();
        }
    }

}

