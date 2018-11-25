﻿namespace main_screen.Manager
{
    partial class add_user
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
            this.Add_user_title = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Choose_Type = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Button();
            this.Teacher = new System.Windows.Forms.RadioButton();
            this.Manager = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Get_User_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_user_title
            // 
            this.Add_user_title.AutoSize = true;
            this.Add_user_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_user_title.Location = new System.Drawing.Point(341, 9);
            this.Add_user_title.Name = "Add_user_title";
            this.Add_user_title.Size = new System.Drawing.Size(179, 29);
            this.Add_user_title.TabIndex = 0;
            this.Add_user_title.Text = "Add a new user";
            this.Add_user_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(65, 96);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(62, 17);
            this.Student.TabIndex = 1;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Choose_Type
            // 
            this.Choose_Type.AutoSize = true;
            this.Choose_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_Type.Location = new System.Drawing.Point(62, 66);
            this.Choose_Type.Name = "Choose_Type";
            this.Choose_Type.Size = new System.Drawing.Size(212, 17);
            this.Choose_Type.TabIndex = 2;
            this.Choose_Type.Text = "Choose the type of the new user";
            this.Choose_Type.Click += new System.EventHandler(this.Choose_Type_Click);
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(697, 338);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 34);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.button1_Click);
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Location = new System.Drawing.Point(65, 119);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(65, 17);
            this.Teacher.TabIndex = 4;
            this.Teacher.TabStop = true;
            this.Teacher.Text = "Teacher";
            this.Teacher.UseVisualStyleBackColor = true;
            this.Teacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(65, 142);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(67, 17);
            this.Manager.TabIndex = 5;
            this.Manager.TabStop = true;
            this.Manager.Text = "Manager";
            this.Manager.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Get_User_ID
            // 
            this.Get_User_ID.AutoSize = true;
            this.Get_User_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_User_ID.Location = new System.Drawing.Point(62, 176);
            this.Get_User_ID.Name = "Get_User_ID";
            this.Get_User_ID.Size = new System.Drawing.Size(91, 17);
            this.Get_User_ID.TabIndex = 7;
            this.Get_User_ID.Text = "Enter user ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter user first name ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter user last name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Get_User_ID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Teacher);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Choose_Type);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Add_user_title);
            this.Name = "add_user";
            this.Text = "add_user";
            this.Load += new System.EventHandler(this.add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Add_user_title;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.Label Choose_Type;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.RadioButton Teacher;
        private System.Windows.Forms.RadioButton Manager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Get_User_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}