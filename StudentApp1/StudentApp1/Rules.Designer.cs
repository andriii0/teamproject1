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
            AcceptButton = new Button();
            RulesText = new Label();
            Header = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.BackColor = Color.DarkOrange;
            AcceptButton.Location = new Point(635, 396);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(136, 42);
            AcceptButton.TabIndex = 9;
            AcceptButton.Text = "Accept";
            AcceptButton.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tomato;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 212);
            label1.Name = "label1";
            label1.Size = new Size(496, 30);
            label1.TabIndex = 12;
            label1.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSalmon;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 257);
            label2.Name = "label2";
            label2.Size = new Size(496, 30);
            label2.TabIndex = 13;
            label2.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(140, 305);
            label3.Name = "label3";
            label3.Size = new Size(496, 30);
            label3.TabIndex = 14;
            label3.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing \r\n";
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Header);
            Controls.Add(RulesText);
            Controls.Add(AcceptButton);
            Name = "Rules";
            Text = "Rules";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AcceptButton;
        private Label RulesText;
        private Label Header;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}