﻿namespace main_screen.Teacher
{
    partial class Surveys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surveys));
            this.Return = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.surveys_results = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answersLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.class_num_cb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grade_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.answersOpA = new System.Windows.Forms.TextBox();
            this.answersOpB = new System.Windows.Forms.TextBox();
            this.answersOpC = new System.Windows.Forms.TextBox();
            this.answersOpD = new System.Windows.Forms.TextBox();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.BackgroundImage = global::main_screen.Properties.Resources.bluebtn;
            this.Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Return.Location = new System.Drawing.Point(11, 343);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 25);
            this.Return.TabIndex = 77;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Transparent;
            this.Submit.BackgroundImage = global::main_screen.Properties.Resources.greenbtn;
            this.Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Submit.Location = new System.Drawing.Point(179, 343);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(109, 25);
            this.Submit.TabIndex = 78;
            this.Submit.Text = "send your survey";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // surveys_results
            // 
            this.surveys_results.BackColor = System.Drawing.Color.Transparent;
            this.surveys_results.BackgroundImage = global::main_screen.Properties.Resources.greybtn;
            this.surveys_results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.surveys_results.FlatAppearance.BorderSize = 0;
            this.surveys_results.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.surveys_results.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.surveys_results.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.surveys_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surveys_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.surveys_results.Location = new System.Drawing.Point(298, 343);
            this.surveys_results.Name = "surveys_results";
            this.surveys_results.Size = new System.Drawing.Size(91, 25);
            this.surveys_results.TabIndex = 79;
            this.surveys_results.Text = "surveys results";
            this.surveys_results.UseVisualStyleBackColor = false;
            this.surveys_results.Click += new System.EventHandler(this.surveys_results_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 80;
            this.label1.Text = "Surveys";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Location = new System.Drawing.Point(38, 80);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(52, 13);
            this.questionLabel.TabIndex = 81;
            this.questionLabel.Text = "Question:";
            // 
            // answersLabel
            // 
            this.answersLabel.AutoSize = true;
            this.answersLabel.BackColor = System.Drawing.Color.Transparent;
            this.answersLabel.Location = new System.Drawing.Point(38, 106);
            this.answersLabel.Name = "answersLabel";
            this.answersLabel.Size = new System.Drawing.Size(50, 13);
            this.answersLabel.TabIndex = 82;
            this.answersLabel.Text = "Answers:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.class_num_cb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.grade_cb);
            this.groupBox1.Location = new System.Drawing.Point(41, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 69);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Class Number:";
            // 
            // class_num_cb
            // 
            this.class_num_cb.FormattingEnabled = true;
            this.class_num_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.class_num_cb.Location = new System.Drawing.Point(216, 15);
            this.class_num_cb.Name = "class_num_cb";
            this.class_num_cb.Size = new System.Drawing.Size(75, 21);
            this.class_num_cb.TabIndex = 13;
            this.class_num_cb.SelectedIndexChanged += new System.EventHandler(this.class_num_cb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grade:";
            // 
            // grade_cb
            // 
            this.grade_cb.FormattingEnabled = true;
            this.grade_cb.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.grade_cb.Location = new System.Drawing.Point(52, 15);
            this.grade_cb.Name = "grade_cb";
            this.grade_cb.Size = new System.Drawing.Size(75, 21);
            this.grade_cb.TabIndex = 11;
            this.grade_cb.SelectedIndexChanged += new System.EventHandler(this.grade_cb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(108, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(108, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(108, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "C:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(108, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "D:";
            // 
            // answersOpA
            // 
            this.answersOpA.Location = new System.Drawing.Point(131, 106);
            this.answersOpA.MaxLength = 40;
            this.answersOpA.Name = "answersOpA";
            this.answersOpA.Size = new System.Drawing.Size(248, 20);
            this.answersOpA.TabIndex = 88;
            // 
            // answersOpB
            // 
            this.answersOpB.Location = new System.Drawing.Point(131, 131);
            this.answersOpB.MaxLength = 40;
            this.answersOpB.Name = "answersOpB";
            this.answersOpB.Size = new System.Drawing.Size(248, 20);
            this.answersOpB.TabIndex = 89;
            // 
            // answersOpC
            // 
            this.answersOpC.Location = new System.Drawing.Point(131, 156);
            this.answersOpC.MaxLength = 40;
            this.answersOpC.Name = "answersOpC";
            this.answersOpC.Size = new System.Drawing.Size(248, 20);
            this.answersOpC.TabIndex = 90;
            // 
            // answersOpD
            // 
            this.answersOpD.Location = new System.Drawing.Point(131, 182);
            this.answersOpD.MaxLength = 40;
            this.answersOpD.Name = "answersOpD";
            this.answersOpD.Size = new System.Drawing.Size(248, 20);
            this.answersOpD.TabIndex = 91;
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(131, 80);
            this.question_txt.MaxLength = 40;
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(248, 20);
            this.question_txt.TabIndex = 92;
            // 
            // Surveys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::main_screen.Properties.Resources.bg_worker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 402);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.answersOpD);
            this.Controls.Add(this.answersOpC);
            this.Controls.Add(this.answersOpB);
            this.Controls.Add(this.answersOpA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.answersLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surveys_results);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Return);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Surveys";
            this.Text = "Surveys";
            this.Load += new System.EventHandler(this.Surveys_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button surveys_results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answersLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox class_num_cb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox grade_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox answersOpA;
        private System.Windows.Forms.TextBox answersOpB;
        private System.Windows.Forms.TextBox answersOpC;
        private System.Windows.Forms.TextBox answersOpD;
        private System.Windows.Forms.TextBox question_txt;
    }
}