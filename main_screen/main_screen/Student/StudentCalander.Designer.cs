﻿namespace main_screen
{
    partial class StudentCalander
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.my_dear_diary_btn = new System.Windows.Forms.Button();
            this.mail_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Profile_btn = new System.Windows.Forms.Button();
            this.contact_page = new System.Windows.Forms.Button();
            this.add_event = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(227, 249);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(547, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 30);
            this.button9.TabIndex = 20;
            this.button9.Text = "Log out";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(547, 264);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 30);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(547, 228);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 30);
            this.button7.TabIndex = 18;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // my_dear_diary_btn
            // 
            this.my_dear_diary_btn.Location = new System.Drawing.Point(547, 192);
            this.my_dear_diary_btn.Name = "my_dear_diary_btn";
            this.my_dear_diary_btn.Size = new System.Drawing.Size(125, 30);
            this.my_dear_diary_btn.TabIndex = 17;
            this.my_dear_diary_btn.Text = "My Dear Diary";
            this.my_dear_diary_btn.UseVisualStyleBackColor = true;
            this.my_dear_diary_btn.Click += new System.EventHandler(this.my_dear_diary_btn_Click);
            // 
            // mail_btn
            // 
            this.mail_btn.Location = new System.Drawing.Point(547, 156);
            this.mail_btn.Name = "mail_btn";
            this.mail_btn.Size = new System.Drawing.Size(125, 30);
            this.mail_btn.TabIndex = 16;
            this.mail_btn.Text = "Mail";
            this.mail_btn.UseVisualStyleBackColor = true;
            this.mail_btn.Click += new System.EventHandler(this.mail_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(547, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Multiplayer event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.Location = new System.Drawing.Point(547, 84);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Size = new System.Drawing.Size(125, 30);
            this.Profile_btn.TabIndex = 14;
            this.Profile_btn.Text = "Profile";
            this.Profile_btn.UseVisualStyleBackColor = true;
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // contact_page
            // 
            this.contact_page.Location = new System.Drawing.Point(547, 48);
            this.contact_page.Name = "contact_page";
            this.contact_page.Size = new System.Drawing.Size(125, 30);
            this.contact_page.TabIndex = 13;
            this.contact_page.Text = "Contact Page";
            this.contact_page.UseVisualStyleBackColor = true;
            this.contact_page.Click += new System.EventHandler(this.contact_page_Click);
            // 
            // add_event
            // 
            this.add_event.Location = new System.Drawing.Point(547, 12);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(125, 30);
            this.add_event.TabIndex = 12;
            this.add_event.Text = "Add event";
            this.add_event.UseVisualStyleBackColor = true;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 26);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // StudentCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.my_dear_diary_btn);
            this.Controls.Add(this.mail_btn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Profile_btn);
            this.Controls.Add(this.contact_page);
            this.Controls.Add(this.add_event);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "StudentCalander";
            this.Text = "Calander - Student";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button my_dear_diary_btn;
        private System.Windows.Forms.Button mail_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Profile_btn;
        private System.Windows.Forms.Button contact_page;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}