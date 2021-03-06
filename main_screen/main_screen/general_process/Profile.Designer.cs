﻿using System;

namespace main_screen.general_process
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.profilePic_img = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hobies_txt = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.freetext_txt = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.birthdate_pckr = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.connections = new System.Windows.Forms.GroupBox();
            this.PEmail_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Email_1st = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_groupbox = new System.Windows.Forms.GroupBox();
            this.view_btn = new System.Windows.Forms.Button();
            this.confirm_new_pass_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.new_pass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profile_name = new System.Windows.Forms.Label();
            this.permi = new System.Windows.Forms.Label();
            this.permissin_txt = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic_img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.connections.SuspendLayout();
            this.password_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.browse_btn);
            this.groupBox2.Controls.Add(this.profilePic_img);
            this.groupBox2.Location = new System.Drawing.Point(550, 338);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(474, 306);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // browse_btn
            // 
            this.browse_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browse_btn.BackgroundImage")));
            this.browse_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse_btn.FlatAppearance.BorderSize = 0;
            this.browse_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.browse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.browse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_btn.Location = new System.Drawing.Point(232, 225);
            this.browse_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(112, 35);
            this.browse_btn.TabIndex = 1;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // profilePic_img
            // 
            this.profilePic_img.Location = new System.Drawing.Point(18, 29);
            this.profilePic_img.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePic_img.Name = "profilePic_img";
            this.profilePic_img.Size = new System.Drawing.Size(206, 231);
            this.profilePic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic_img.TabIndex = 0;
            this.profilePic_img.TabStop = false;
            this.profilePic_img.Click += new System.EventHandler(this.profilePic_img_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hobies_txt);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.freetext_txt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.birthdate_pckr);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.address_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(18, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(474, 611);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // hobies_txt
            // 
            this.hobies_txt.Location = new System.Drawing.Point(22, 426);
            this.hobies_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hobies_txt.Name = "hobies_txt";
            this.hobies_txt.Size = new System.Drawing.Size(426, 146);
            this.hobies_txt.TabIndex = 7;
            this.hobies_txt.Text = "";
            this.hobies_txt.TextChanged += new System.EventHandler(this.hobies_txt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 402);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Hobies";
            // 
            // freetext_txt
            // 
            this.freetext_txt.Location = new System.Drawing.Point(22, 200);
            this.freetext_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freetext_txt.Name = "freetext_txt";
            this.freetext_txt.Size = new System.Drawing.Size(426, 156);
            this.freetext_txt.TabIndex = 5;
            this.freetext_txt.Text = "";
            this.freetext_txt.TextChanged += new System.EventHandler(this.freetext_txt_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 175);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Free Text";
            // 
            // birthdate_pckr
            // 
            this.birthdate_pckr.CustomFormat = "yyyy-MM-dd";
            this.birthdate_pckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdate_pckr.Location = new System.Drawing.Point(100, 102);
            this.birthdate_pckr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthdate_pckr.Name = "birthdate_pckr";
            this.birthdate_pckr.Size = new System.Drawing.Size(140, 26);
            this.birthdate_pckr.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Birthdate";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(100, 40);
            this.address_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(348, 26);
            this.address_txt.TabIndex = 1;
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Address";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::main_screen.Properties.Resources.greenbtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(912, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connections
            // 
            this.connections.BackColor = System.Drawing.Color.Transparent;
            this.connections.Controls.Add(this.PEmail_txt);
            this.connections.Controls.Add(this.label10);
            this.connections.Controls.Add(this.phone_txt);
            this.connections.Controls.Add(this.label7);
            this.connections.Controls.Add(this.Email_1st);
            this.connections.Controls.Add(this.label6);
            this.connections.Location = new System.Drawing.Point(550, 74);
            this.connections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connections.Name = "connections";
            this.connections.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connections.Size = new System.Drawing.Size(474, 255);
            this.connections.TabIndex = 13;
            this.connections.TabStop = false;
            this.connections.Text = "Connections";
            // 
            // PEmail_txt
            // 
            this.PEmail_txt.Location = new System.Drawing.Point(9, 200);
            this.PEmail_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PEmail_txt.Name = "PEmail_txt";
            this.PEmail_txt.Size = new System.Drawing.Size(326, 26);
            this.PEmail_txt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Parent email:";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(9, 128);
            this.phone_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(326, 26);
            this.phone_txt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone number:";
            // 
            // Email_1st
            // 
            this.Email_1st.Location = new System.Drawing.Point(14, 60);
            this.Email_1st.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_1st.Name = "Email_1st";
            this.Email_1st.Size = new System.Drawing.Size(326, 26);
            this.Email_1st.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // password_groupbox
            // 
            this.password_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.password_groupbox.Controls.Add(this.view_btn);
            this.password_groupbox.Controls.Add(this.confirm_new_pass_txt);
            this.password_groupbox.Controls.Add(this.label3);
            this.password_groupbox.Controls.Add(this.label1);
            this.password_groupbox.Controls.Add(this.new_pass_txt);
            this.password_groupbox.Controls.Add(this.label2);
            this.password_groupbox.Location = new System.Drawing.Point(18, 694);
            this.password_groupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_groupbox.Name = "password_groupbox";
            this.password_groupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_groupbox.Size = new System.Drawing.Size(474, 201);
            this.password_groupbox.TabIndex = 12;
            this.password_groupbox.TabStop = false;
            this.password_groupbox.Text = "Update Password";
            // 
            // view_btn
            // 
            this.view_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_btn.BackgroundImage")));
            this.view_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_btn.FlatAppearance.BorderSize = 0;
            this.view_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.view_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.view_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_btn.Location = new System.Drawing.Point(383, 154);
            this.view_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(66, 35);
            this.view_btn.TabIndex = 6;
            this.view_btn.Text = "view";
            this.view_btn.UseVisualStyleBackColor = true;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // confirm_new_pass_txt
            // 
            this.confirm_new_pass_txt.Location = new System.Drawing.Point(13, 154);
            this.confirm_new_pass_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirm_new_pass_txt.Name = "confirm_new_pass_txt";
            this.confirm_new_pass_txt.Size = new System.Drawing.Size(322, 26);
            this.confirm_new_pass_txt.TabIndex = 5;
            this.confirm_new_pass_txt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "confirm your password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would you like to change the password?";
            // 
            // new_pass_txt
            // 
            this.new_pass_txt.Location = new System.Drawing.Point(13, 86);
            this.new_pass_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_pass_txt.Name = "new_pass_txt";
            this.new_pass_txt.Size = new System.Drawing.Size(326, 26);
            this.new_pass_txt.TabIndex = 3;
            this.new_pass_txt.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "type your new password:";
            // 
            // profile_name
            // 
            this.profile_name.AutoSize = true;
            this.profile_name.BackColor = System.Drawing.Color.Transparent;
            this.profile_name.Location = new System.Drawing.Point(14, 17);
            this.profile_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profile_name.Name = "profile_name";
            this.profile_name.Size = new System.Drawing.Size(67, 20);
            this.profile_name.TabIndex = 11;
            this.profile_name.Text = "X profile";
            // 
            // permi
            // 
            this.permi.AutoSize = true;
            this.permi.BackColor = System.Drawing.Color.Transparent;
            this.permi.Location = new System.Drawing.Point(550, 17);
            this.permi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permi.Name = "permi";
            this.permi.Size = new System.Drawing.Size(90, 20);
            this.permi.TabIndex = 18;
            this.permi.Text = "Permission:";
            // 
            // permissin_txt
            // 
            this.permissin_txt.AutoSize = true;
            this.permissin_txt.BackColor = System.Drawing.Color.Transparent;
            this.permissin_txt.Location = new System.Drawing.Point(651, 17);
            this.permissin_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.permissin_txt.Name = "permissin_txt";
            this.permissin_txt.Size = new System.Drawing.Size(76, 20);
            this.permissin_txt.TabIndex = 19;
            this.permissin_txt.Text = "Unknown";
            // 
            // return_btn
            // 
            this.return_btn.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.return_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Location = new System.Drawing.Point(773, 694);
            this.return_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(112, 35);
            this.return_btn.TabIndex = 20;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 1050);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.permissin_txt);
            this.Controls.Add(this.permi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connections);
            this.Controls.Add(this.password_groupbox);
            this.Controls.Add(this.profile_name);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Profile";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic_img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.connections.ResumeLayout(false);
            this.connections.PerformLayout();
            this.password_groupbox.ResumeLayout(false);
            this.password_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.PictureBox profilePic_img;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox hobies_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox freetext_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker birthdate_pckr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox connections;
        private System.Windows.Forms.TextBox PEmail_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email_1st;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox password_groupbox;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.TextBox confirm_new_pass_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_pass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label profile_name;
        private System.Windows.Forms.Label permi;
        private System.Windows.Forms.Label permissin_txt;
        private System.Windows.Forms.Button return_btn;
    }
}