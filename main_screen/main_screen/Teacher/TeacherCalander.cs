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
using System.Net;
using System.Net.Mail;
using USER;
using database_location;
using System.IO;
using check_funcs;

namespace main_screen
{
    public partial class TeacherCalander : Form
    {
        public TeacherCalander()
        {
            InitializeComponent();
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            general_process.Add_event_form Mc = new general_process.Add_event_form();
            this.Hide();
            Mc.Show();
        }

        private void TeacherCalander_Load(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();

            string query;

           
            query = "Select item from checklists where user_id ='" + log_in_page.userId + "'";
            

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                checklist.Items.Add(dtb.Rows[i]["item"].ToString().Trim());
            }

           
            string rownumOfMax = "0";
            

            query = "Select MAX(msg_id) from bulletin_board";

            sda = new SqlDataAdapter(query, conn);
            dtb = new DataTable();
            sda.Fill(dtb);

            if (dtb.Rows.Count > 0)
            {
                rownumOfMax = dtb.Rows[0][0].ToString();
                query = "Select msg from bulletin_board where msg_id ='" + rownumOfMax + "'";

                sda = new SqlDataAdapter(query, conn);
                dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count > 0)
                {
                    motd_txt.Text = dtb.Rows[0][0].ToString();
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            log_in_page frmCal = new log_in_page();
            frmCal.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher.SendEmail frmCal = new Teacher.SendEmail();
            frmCal.Show();
            Visible = false;
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            general_process.Profile profile = new general_process.Profile();
            this.Hide();
            profile.Show();
        }

        private void multi_studnt_event_btn_Click(object sender, EventArgs e)
        {
            Teacher.multiStudentEvent n = new Teacher.multiStudentEvent();
            n.Show();
            this.Hide();
        }

        private void add_chklist_btn_Click(object sender, EventArgs e)
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();
            if (add_chklist_txt.Text=="")
            {
                MessageBox.Show("You realy got nothig to do?");
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO checklists(user_id,item) VALUES(@id,@item) ", conn);
                cmd.Parameters.Add("@id", log_in_page.userId);
                cmd.Parameters.Add("@item", add_chklist_txt.Text);

                cmd.ExecuteNonQuery();

                checklist.Items.Add(add_chklist_txt.Text);
                

                add_chklist_txt.Text = "";


            }
        }

        private void clearCL()
        {
            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();
            for (int i = 0; i<checklist.Items.Count;i++)
            {
                if(checklist.GetItemCheckState(i) == CheckState.Checked)
                {
                    try
                    {
                        
                        SqlCommand cmd = new SqlCommand("DELETE FROM checklists WHERE item= @item and user_Id=@id", conn);
                        cmd.Parameters.AddWithValue("@item", checklist.Items[i].ToString());
                        cmd.Parameters.AddWithValue("@id", log_in_page.userId);
                        cmd.ExecuteNonQuery();
                        checklist.Items.Remove(checklist.Items[i]);
                    }
                    catch
                    {

                    }
                }
            }
            conn.Close();

        }

        private bool CheckIfClear()
        {
            for (int i = 0; i < checklist.Items.Count; i++)
            {
                if (checklist.GetItemCheckState(i) == CheckState.Checked)
                {
                    return false;
                }

            }
            return true;
        }
            


        private void clear_done_btn_Click(object sender, EventArgs e)
        {
            while (!CheckIfClear())
            {
                clearCL();
            }
        }

        private void reception_hours_Click(object sender, EventArgs e)
        {
            Teacher.reception_hours n = new Teacher.reception_hours();
            n.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            /*
             * show events on calander.
             */
            listView1.Items.Clear();

            int thisday = monthCalendar1.SelectionRange.Start.Day;
            int thismonth = monthCalendar1.SelectionRange.Start.Month;
            int thisyear = monthCalendar1.SelectionRange.Start.Year;
            string dayOfWeek = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();

            

            dataBase dataBase = new dataBase();
            SqlConnection conn = dataBase.connect_to_scheduluz_DB();

            conn.Open();


            string id = "'" + log_in_page.userId.ToString() + "'";

            string query = "Select Event_ID from Events_to_Users where User_ID=" + id;



            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                string event_id = "'" + dtb.Rows[i][0].ToString() + "'";

                string query2 = "Select * from Events where Event_id=" + event_id;

                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                DataTable dtb2 = new DataTable();
                sda2.Fill(dtb2);
                /* 1/15/2019 00:00:00*/
                if (dtb2.Rows.Count > 0)
                {
                    if (dtb2.Rows[0]["date"].ToString() == thismonth.ToString() + "/" + thisday.ToString() + "/" + thisyear.ToString() + " 00:00:00")
                    {
                        string hours_end = dtb2.Rows[0]["hours_end"].ToString().Trim();

                        if (hours_end.Length < 2)
                        {
                            hours_end = "0" + hours_end;
                        }

                        string hours_start = dtb2.Rows[0]["hours_start"].ToString().Trim();

                        if (hours_start.Length < 2)
                        {
                            hours_start = "0" + hours_start;
                        }

                        string minutes_start = dtb2.Rows[0]["minutes_start"].ToString().Trim();

                        if (minutes_start.Length < 2)
                        {
                            minutes_start = "0" + minutes_start;
                        }

                        string minutes_end = dtb2.Rows[0]["minutes_end"].ToString().Trim();

                        if (minutes_end.Length < 2)
                        {
                            minutes_end = "0" + minutes_end;
                        }

                        ListViewItem item = new ListViewItem(dtb2.Rows[0]["Event_name"].ToString().Trim());
                        item.SubItems.Add(hours_start + ":" + minutes_start);
                        item.SubItems.Add(hours_end + ":" + minutes_end);

                        /*
                         * choosing color -- need to update if updated.
                         */
                        switch (dtb2.Rows[0]["event_kind"].ToString().Trim())
                        {
                            case "Muliplayer":
                                item.BackColor = Color.Orange;
                                break;

                            case "School":
                                item.BackColor = Color.YellowGreen;
                                break;

                            case "Regular":
                                item.BackColor = Color.SteelBlue;
                                break;

                            default:
                                break;
                        }
                        listView1.Items.Add(item);
                    }
                }

            }

            string query3 = "Select * from weekly_events where day_in_week='" + dayOfWeek+"'";

            SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
            DataTable dtb3 = new DataTable();
            sda3.Fill(dtb3);

            for (int i = 0; i < dtb3.Rows.Count; i++)
            {
                string hours_end = dtb3.Rows[i]["ends"].ToString().Trim();

                if (hours_end.Length < 2)
                {
                    hours_end = "0" + hours_end;
                }

                string hours_start = dtb3.Rows[i]["start"].ToString().Trim();

                if (hours_start.Length < 2)
                {
                    hours_start = "0" + hours_start;
                }

                string minutes_start = "00";



                string minutes_end = "00";

               
                ListViewItem item = new ListViewItem(dtb3.Rows[i]["title"].ToString().Trim());
                item.SubItems.Add(hours_start + ":" + minutes_start);
                item.SubItems.Add(hours_end + ":" + minutes_end);
                item.BackColor = Color.IndianRed;

                listView1.Items.Add(item);

            }

            


    }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
