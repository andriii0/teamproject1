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
            HelloText.ForeColor = Color.DarkOrchid;
            HelloText.Location = new Point(373, 65);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(45, 29);
            HelloText.TabIndex = 0;
            HelloText.Text = "Hi!";
            // 
            // ProfileImage
            // 
            ProfileImage.Location = new Point(687, 25);
            ProfileImage.Name = "ProfileImage";
            ProfileImage.Size = new Size(102, 79);
            ProfileImage.TabIndex = 1;
            ProfileImage.TabStop = false;
            // 
            // Schedule
            // 
            Schedule.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Schedule.Location = new Point(520, 217);
            Schedule.Name = "Schedule";
            Schedule.Size = new Size(185, 118);
            Schedule.TabIndex = 2;
            Schedule.Text = "Schedule\r\n";
            Schedule.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            ToDo.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ToDo.Location = new Point(306, 217);
            ToDo.Name = "ToDo";
            ToDo.Size = new Size(185, 118);
            ToDo.TabIndex = 3;
            ToDo.Text = "To Do List";
            ToDo.UseVisualStyleBackColor = true;
            // 
            // Announcements
            // 
            Announcements.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Announcements.Location = new Point(98, 217);
            Announcements.Name = "Announcements";
            Announcements.Size = new Size(185, 118);
            Announcements.TabIndex = 5;
            Announcements.Text = "Announcements";
            Announcements.UseVisualStyleBackColor = true;
            Announcements.Click += button1_Click;
            // 
            // Rules
            // 
            Rules.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Rules.Location = new Point(306, 372);
            Rules.Name = "Rules";
            Rules.RightToLeft = RightToLeft.Yes;
            Rules.Size = new Size(185, 118);
            Rules.TabIndex = 6;
            Rules.Text = "House Rules";
            Rules.UseVisualStyleBackColor = true;
            Rules.Click += Rules_Click;
            // 
            // LogOutLabel
            // 
            LogOutLabel.AutoSize = true;
            LogOutLabel.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutLabel.ForeColor = Color.DarkOrchid;
            LogOutLabel.Location = new Point(687, 117);
            LogOutLabel.Name = "LogOutLabel";
            LogOutLabel.Size = new Size(100, 29);
            LogOutLabel.TabIndex = 7;
            LogOutLabel.Text = "Log Out";
            LogOutLabel.Click += label1_Click;
            // 
            // Complaints
            // 
            Complaints.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Complaints.Location = new Point(98, 372);
            Complaints.Name = "Complaints";
            Complaints.Size = new Size(185, 118);
            Complaints.TabIndex = 8;
            Complaints.Text = "Leave a complaints";
            Complaints.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            Notes.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Notes.Location = new Point(520, 372);
            Notes.Name = "Notes";
            Notes.RightToLeft = RightToLeft.Yes;
            Notes.Size = new Size(185, 118);
            Notes.TabIndex = 9;
            Notes.Text = "Notes";
            Notes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 638);
            Controls.Add(Notes);
            Controls.Add(Complaints);
            Controls.Add(LogOutLabel);
            Controls.Add(Rules);
            Controls.Add(Announcements);
            Controls.Add(ToDo);
            Controls.Add(Schedule);
            Controls.Add(ProfileImage);
            Controls.Add(HelloText);
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