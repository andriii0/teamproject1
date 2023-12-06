namespace StudentApp1
{
    partial class NoteDisplayForm
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
            AddNotes = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 40);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(160, 82);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AddNotes
            // 
            AddNotes.Location = new Point(1172, 41);
            AddNotes.Name = "AddNotes";
            AddNotes.Size = new Size(175, 81);
            AddNotes.TabIndex = 2;
            AddNotes.Text = "Add a note";
            AddNotes.UseVisualStyleBackColor = true;
            AddNotes.Click += AddNotes_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Location = new Point(12, 187);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(1396, 658);
            tableLayoutPanel.TabIndex = 3;
            // 
            // NoteDisplayForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 857);
            Controls.Add(tableLayoutPanel);
            Controls.Add(AddNotes);
            Controls.Add(BackButton);
            Name = "NoteDisplayForm";
            Text = "NoteDisplayForm";
            ResumeLayout(false);
        }

        #endregion
        private Button BackButton;
        private Button AddNotes;
        private TableLayoutPanel tableLayoutPanel;
    }
}