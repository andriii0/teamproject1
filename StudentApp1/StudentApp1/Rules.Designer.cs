namespace StudentApp1
{
    partial class Rules
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

        string Name = "Andrii";
        string Surname = "Matviienko";

        private void InitializeComponent()
        {
            HelloText = new Label();
            label1 = new Label();
            AcceptButton = new Button();
            RulesText = new Label();
            Header = new Label();
            SuspendLayout();
            // 
            // HelloText
            // 
            HelloText.AutoSize = true;
            HelloText.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HelloText.ForeColor = Color.DarkOrchid;
            HelloText.Location = new Point(356, 20);
            HelloText.Name = "HelloText";
            HelloText.Size = new Size(45, 29);
            HelloText.TabIndex = 1;
            HelloText.Text = "Hi!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(688, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 8;
            label1.Text = "Log Out";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(635, 396);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(136, 42);
            AcceptButton.TabIndex = 9;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // RulesText
            // 
            RulesText.AutoSize = true;
            RulesText.BackColor = Color.Chocolate;
            RulesText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            RulesText.Location = new Point(140, 162);
            RulesText.Name = "RulesText";
            RulesText.Size = new Size(496, 30);
            RulesText.TabIndex = 10;
            RulesText.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing \r\n";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Header.Location = new Point(140, 112);
            Header.Name = "Header";
            Header.Size = new Size(108, 32);
            Header.TabIndex = 11;
            Header.Text = "Heading";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Header);
            Controls.Add(RulesText);
            Controls.Add(AcceptButton);
            Controls.Add(label1);
            Controls.Add(HelloText);
            Name = "Rules";
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloText;
        private Label label1;
        private Button AcceptButton;
        private Label RulesText;
        private Label Header;
    }
}