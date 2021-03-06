﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using database_location;

namespace main_screen.Manager
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_user_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ManagerCalander frmAEF = new ManagerCalander();
            frmAEF.Show();
            Visible = false;
        }

        private void Choose_Type_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            bool user_exsist = false;
            try
           
            {
                dataBase dataBase = new dataBase();
                SqlConnection con = dataBase.connect_to_scheduluz_DB();
                string query = "Select * from connection_details Where userName = '" + userIDtextBox.Text.Trim() + "' or userName = '" + userFirstNameTextBox.Text.Trim()+userLastNameTextBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count > 0)
                    user_exsist = true;


            }
            catch
            {
                MessageBox.Show("Problem detected. please contact your Scheduluz Guide for more information.");
            }

            string per;
            if (Student.Checked)
                per = "student";
            else if (Teacher.Checked)
                per = "teacher";
            else if (Manager.Checked)
                per = "manager";
            else
                per = "none";

            
            

            try
            
            {
                if (userIDtextBox.Text[0] == '0')
                {
                    throw new System.ArgumentException("Parameter cannot be null", "original");
                }


                if (userIDtextBox.Text.Length == 0 || userFirstNameTextBox.Text.Length == 0 || userLastNameTextBox.Text.Length == 0)
                {
                    MessageBox.Show("please fill all the fileds");
                }
                else if (user_exsist == false)
                {

                    dataBase dataBase = new dataBase();
                    SqlConnection con = dataBase.connect_to_scheduluz_DB();
                    con.Open();
                    SqlCommand cmd;
                    cmd = new SqlCommand("INSERT INTO connection_details (id,userName,password,permission) VALUES (@id,@userName,@password,@permission)", con);
                    cmd.Parameters.Add("@id", userIDtextBox.Text);
                    cmd.Parameters.Add("@userName", userFirstNameTextBox.Text + userLastNameTextBox.Text);
                    cmd.Parameters.Add("@password", userIDtextBox.Text);
                    cmd.Parameters.Add("@permission", per);
                    cmd.ExecuteNonQuery();


                    dataBase dataBase2 = new dataBase();
                    SqlConnection con2 = dataBase.connect_to_scheduluz_DB();
                    con2.Open();
                    SqlCommand cmd2;
                    cmd2 = new SqlCommand("INSERT INTO users (id,name,lastName,permission) VALUES (@id,@name,@lastName,@permission)", con2);
                    cmd2.Parameters.Add("@id", userIDtextBox.Text);
                    cmd2.Parameters.Add("@name", userFirstNameTextBox.Text);
                    cmd2.Parameters.Add("@lastName", userLastNameTextBox.Text);
                    //cmd2.Parameters.Add("@password", userIDtextBox.Text);
                    cmd2.Parameters.Add("@permission", per);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("has added");

                    userFirstNameTextBox.Clear();
                    userLastNameTextBox.Clear();
                    userIDtextBox.Clear();


                }
                else
                {
                    MessageBox.Show(userFirstNameTextBox.Text.Trim() + " " + userLastNameTextBox.Text.Trim() + " already exsists in the system");
                }
            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("ID can't start with 0.");
            }
        

           catch
            {
                MessageBox.Show("Problem detected. this id might be registered already.");
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ManagerCalander frmCal = new ManagerCalander();
            frmCal.Show();
            Visible = false;
        }
    }
}
