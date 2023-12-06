namespace StudentApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            HelloText = new Label();
            ProfileImage = new PictureBox();
            Schedule = new Button();
            ToDo = new Button();
            Announcements = new Button();
            Rules = new Button();
            LogOutLabel = new Label();
            Complaints = new Button();
            Notes = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfileImage).BeginInit();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HelloText.ForeColor = Color.WhiteSmoke;
            HelloText.Location = new Point(533, 108);
            HelloText.Margin = new Padding(4, 0, 4, 0);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(68, 44);
            HelloText.TabIndex = 0;
            HelloText.Text = "Hi!";
            // 
            // ProfileImage
            // 
            ProfileImage.Location = new Point(981, 42);
            ProfileImage.Margin = new Padding(4, 5, 4, 5);
            ProfileImage.Name = "ProfileImage";
            ProfileImage.Size = new Size(146, 132);
            ProfileImage.TabIndex = 1;
            ProfileImage.TabStop = false;
            // 
            // Schedule
            // 
            Schedule.BackColor = Color.Snow;
            Schedule.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Schedule.Location = new Point(743, 362);
            Schedule.Margin = new Padding(4, 5, 4, 5);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(264, 197);
            Schedule.TabIndex = 2;
            Schedule.Text = "Schedule\r\n";
            Schedule.UseVisualStyleBackColor = false;
            // 
            // ToDo
            // 
            ToDo.BackColor = Color.Snow;
            ToDo.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToDo.Location = new Point(437, 362);
            ToDo.Margin = new Padding(4, 5, 4, 5);
            ToDo.Name = "ToDo";
            ToDo.Size = new Size(264, 197);
            ToDo.TabIndex = 3;
            ToDo.Text = "To Do List";
            ToDo.UseVisualStyleBackColor = false;
            // 
            // Announcements
            // 
            Announcements.BackColor = Color.Snow;
            Announcements.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Announcements.Location = new Point(140, 362);
            Announcements.Margin = new Padding(4, 5, 4, 5);
            Announcements.Name = "Announcements";
            Announcements.Size = new Size(264, 197);
            Announcements.TabIndex = 5;
            Announcements.Text = "Announcements";
            Announcements.UseVisualStyleBackColor = false;
            Announcements.Click += button1_Click;
            // 
            // Rules
            // 
            Rules.BackColor = Color.Snow;
            Rules.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Rules.Location = new Point(437, 620);
            Rules.Margin = new Padding(4, 5, 4, 5);
            Rules.Name = "Rules";
            Rules.RightToLeft = RightToLeft.Yes;
            Rules.Size = new Size(264, 197);
            Rules.TabIndex = 6;
            Rules.Text = "House Rules";
            Rules.UseVisualStyleBackColor = false;
            Rules.Click += Rules_Click;
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutLabel.ForeColor = Color.GhostWhite;
            LogOutLabel.Location = new Point(981, 195);
            LogOutLabel.Margin = new Padding(4, 0, 4, 0);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(148, 44);
            LogOutLabel.TabIndex = 7;
            LogOutLabel.Text = "Log Out";
            LogOutLabel.Click += label1_Click;
            // 
            // Complaints
            // 
            Complaints.BackColor = Color.Snow;
            Complaints.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Complaints.Location = new Point(140, 620);
            Complaints.Margin = new Padding(4, 5, 4, 5);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(264, 197);
            Complaints.TabIndex = 8;
            Complaints.Text = "Leave a complaints";
            Complaints.UseVisualStyleBackColor = false;
            // 
            // Notes
            // 
            Notes.BackColor = Color.Snow;
            Notes.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Notes.Location = new Point(743, 620);
            Notes.Margin = new Padding(4, 5, 4, 5);
            Notes.Name = "Notes";
            Notes.RightToLeft = RightToLeft.Yes;
            Notes.Size = new Size(264, 197);
            Notes.TabIndex = 9;
            Notes.Text = "Notes";
            Notes.UseVisualStyleBackColor = false;
            Notes.Click += Notes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1207, 1063);
            Controls.Add(Notes);
            Controls.Add(Complaints);
            Controls.Add(LogOutLabel);
            Controls.Add(Rules);
            Controls.Add(Announcements);
            Controls.Add(ToDo);
            Controls.Add(Schedule);
            Controls.Add(ProfileImage);
            Controls.Add(HelloText);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProfileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private PictureBox ProfileImage;
        private Button Schedule;
        private Button ToDo;
        private Button Announcements;
        private Button Rules;
        private Label LogOutLabel;
        private Button Complaints;
        private Button Notes;
    }
}