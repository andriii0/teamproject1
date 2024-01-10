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
    public partial class AddNoteForm : Form
    {
        private List<Note> notes;
        private const int MaxNotes = 4;

        public AddNoteForm()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            try
            {
                string json = File.ReadAllText("notes.json");
                notes = JsonConvert.DeserializeObject<List<Note>>(json);
            }
            catch (FileNotFoundException)
            {
                notes = new List<Note>();
            }
        }

        private void SaveNotes()
        {
            string json = JsonConvert.SerializeObject(notes);
            File.WriteAllText("notes.json", json);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NoteDisplayForm noteDisplayForm = new NoteDisplayForm(CurrentUser.LoggedInUser);
            this.Close();
            noteDisplayForm.Show();
        }
        //сука ты дибил ничего не работает
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(NoteTextBox.Text);
            notes.Add(newNote);

            if (notes.Count > MaxNotes)
            {
                notes.RemoveAt(0);
            }

            SaveNotes();
            NoteDisplayForm noteDisplayForm = new NoteDisplayForm(CurrentUser.LoggedInUser);
            this.Close();
            noteDisplayForm.Show();
        }
    }

}
