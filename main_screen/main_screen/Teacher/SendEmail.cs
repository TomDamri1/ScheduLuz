﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using check_funcs;

namespace main_screen.Teacher
{
    public partial class SendEmail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public SendEmail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_funcs.CheckDetails check = new CheckDetails();
            
            if (check.CheckEmail(txtTo.Text) && (check.CheckEmail(txtCC.Text) ||txtCC.Text== ""))
            try
            {
                this.timer1.Start();
                login = new NetworkCredential(txtUser.Text, txtPassword.Text);
                client = new SmtpClient(txtSmtp.Text);
                client.Port = Convert.ToInt32(txtPort.Text);
                client.EnableSsl = chkSSL.Checked;
                client.Credentials = login;
                msg = new MailMessage
                {
                    From = new MailAddress(txtUser.Text + txtSmtp.Text.Replace("smtp.", "@"), "ScheduLuz", Encoding.UTF8)
                };
                msg.To.Add(new MailAddress(txtTo.Text));
                if (!string.IsNullOrEmpty(txtCC.Text))
                    msg.To.Add(new MailAddress(txtCC.Text));
                msg.Subject = txtSubject.Text;
                msg.Body = txtMessage.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);
            }
            catch
            {
                this.timer1.Stop();
                MessageBox.Show("Error Accured, please check your internet connection");
            }

        }

        private void SendCompletedCallBack(object sender , AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                progressBar1.Value = 100;
                if(progressBar1.Value==100)
                    MessageBox.Show("Your message has been succssfully sent", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                TeacherCalander frmCal = new TeacherCalander();
                frmCal.Show();
                Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TeacherCalander frmCal = new TeacherCalander();
            frmCal.Show();
            Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void SendEmail_Load(object sender, EventArgs e)
        {

        }

        private void txtCC_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
