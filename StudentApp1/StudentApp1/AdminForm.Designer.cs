﻿namespace StudentApp1
{
    partial class AdminForm
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
            tabPage2 = new TabPage();
            LogOutLabel2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel5 = new Panel();
            textBox5 = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            textBox4 = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegisterButton = new Button();
            LogOutLabel1 = new Label();
            panel6 = new Panel();
            textBox6 = new TextBox();
            label7 = new Label();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LogOutLabel2);
            tabPage2.Location = new Point(4, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Announcements";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogOutLabel2
            // 
            LogOutLabel2.AutoSize = true;
            LogOutLabel2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutLabel2.ForeColor = Color.DarkOrchid;
            LogOutLabel2.Location = new Point(683, 3);
            LogOutLabel2.Name = "LogOutLabel2";
            LogOutLabel2.Size = new Size(100, 29);
            LogOutLabel2.TabIndex = 9;
            LogOutLabel2.Text = "Log Out";
            LogOutLabel2.Click += LogOutLabel2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 449);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(RegisterButton);
            tabPage1.Controls.Add(LogOutLabel1);
            tabPage1.Location = new Point(4, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Register";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(16, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(540, 49);
            panel5.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(117, 6);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(420, 34);
            textBox5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(116, 31);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(16, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(465, 49);
            panel4.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(366, 34);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(352, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 49);
            panel3.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(61, 6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 34);
            textBox3.TabIndex = 10;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(52, 31);
            label4.TabIndex = 12;
            label4.Text = "Age";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(16, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 49);
            panel2.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 34);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 49);
            panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 34);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(389, 31);
            label1.TabIndex = 11;
            label1.Text = "To register a new user, please, type";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(299, 318);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(182, 61);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LogOutLabel1
            // 
            LogOutLabel1.AutoSize = true;
            LogOutLabel1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LogOutLabel1.ForeColor = Color.DarkOrchid;
            LogOutLabel1.Location = new Point(683, 3);
            LogOutLabel1.Name = "LogOutLabel1";
            LogOutLabel1.Size = new Size(100, 29);
            LogOutLabel1.TabIndex = 8;
            LogOutLabel1.Text = "Log Out";
            LogOutLabel1.Click += LogOutLabel1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(386, 117);
            panel6.Name = "panel6";
            panel6.Size = new Size(210, 49);
            panel6.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(111, 9);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 34);
            textBox6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 6);
            label7.Name = "label7";
            label7.Size = new Size(102, 31);
            label7.TabIndex = 12;
            label7.Text = "Room№";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label LogOutLabel1;
        private Label LogOutLabel2;
        private Button RegisterButton;
        private Panel panel1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label3;
        private Panel panel3;
        private TextBox textBox3;
        private Label label4;
        private Panel panel4;
        private TextBox textBox4;
        private Label label5;
        private Panel panel5;
        private TextBox textBox5;
        private Label label6;
        private Panel panel6;
        private TextBox textBox6;
        private Label label7;
    }
}