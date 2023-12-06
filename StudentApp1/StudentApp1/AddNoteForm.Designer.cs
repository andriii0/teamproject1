namespace StudentApp1
{
    partial class AddNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackButton = new Button();
            AddNoteButton = new Button();
            label1 = new Label();
            NoteTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 41);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(145, 64);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddNoteButton
            // 
            AddNoteButton.Location = new Point(609, 692);
            AddNoteButton.Name = "AddNoteButton";
            AddNoteButton.Size = new Size(250, 61);
            AddNoteButton.TabIndex = 2;
            AddNoteButton.Text = "Submit";
            AddNoteButton.UseVisualStyleBackColor = true;
            AddNoteButton.Click += AddNoteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(668, 236);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 4;
            label1.Text = "Add a note";
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(520, 299);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(415, 167);
            NoteTextBox.TabIndex = 5;
            NoteTextBox.Text = "";
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 855);
            Controls.Add(NoteTextBox);
            Controls.Add(label1);
            Controls.Add(AddNoteButton);
            Controls.Add(BackButton);
            Name = "AddNoteForm";
            Text = "AddNoteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BackButton;
        private Button AddNoteButton;
        private Label label1;
        private RichTextBox NoteTextBox;
    }
}