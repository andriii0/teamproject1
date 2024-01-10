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
using Microsoft.VisualBasic.ApplicationServices;


namespace StudentApp1
{

    public partial class NoteDisplayForm : Form
    {
        private User authenticatedUser;

        private List<Note> notes;
        public NoteDisplayForm(User user)
        {
            InitializeComponent();
            LoadNotes();
            authenticatedUser = user;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(authenticatedUser);
            this.Close();
            form1.Show();
        }
        private void LoadNotes()
        {
            // Load notes from JSON file
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
                Label noteLabel = CreateNoteLabel(note);
                tableLayoutPanel.Controls.Add(noteLabel);
            }
        }

        private Label CreateNoteLabel(Note note)
        {
            Label label = new Label
            {
                BorderStyle = BorderStyle.Fixed3D,
                Width = 400,
                Height = 325,
                Text = $"Author: {CurrentUser.LoggedInUser.Name}\n{note.Content}"
            };

            return label;
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            this.Close();
            AddNoteForm addNoteForm = new AddNoteForm();
            addNoteForm.Show();
        }
    }

}

