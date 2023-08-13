using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class PastMedicalHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            loadPMHHistory();


        }
        protected void loadPMHHistory()
        {
            if (Session["smrn"] != null)
            {
                string v = Session["smrn"].ToString();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Medical_history where patient_id=" + v + " and history_type='PMH' ", con);

                int yeartoday = DateTime.Now.Year;
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        if (r.GetValue(1).ToString() == "Diabetes")
                        {
                            CheckBox1.Checked = true;
                            txtDiabNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtDiabNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox2.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Hypertension")
                        {
                            CheckBox3.Checked = true;
                            txtHyperNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtHyperNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox3.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "MI")
                        {
                            CheckBox5.Checked = true;
                            txtMINotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtMINotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox4.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Stroke")
                        {
                            CheckBox7.Checked = true;
                            txtStrokeNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtStrokeNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox5.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Hepatitis")
                        {
                            CheckBox9.Checked = true;
                            txtHepaNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtHepaNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox6.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Kidney Stones")
                        {
                            CheckBox11.Checked = true;
                            txtKidStoNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtKidStoNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox7.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Asthma")
                        {
                            CheckBox13.Checked = true;
                            txtAsthNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtAsthNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox8.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Kidney Disease")
                        {
                            CheckBox15.Checked = true;
                            txtKidDisNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtKidDisNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox9.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Prostate Cancer")
                        {
                            CheckBox17.Checked = true;
                            txtProsCanNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtProsCanNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox10.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Urinary Cancer")
                        {
                            CheckBox19.Checked = true;
                            txtUriNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtUriNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox11.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Epilpsy")
                        {
                            CheckBox21.Checked = true;
                            txtEpilNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtEpilNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox12.Text = yrs.ToString();

                        }
                        if (r.GetValue(1).ToString() == "Cancer")
                        {
                            CheckBox23.Checked = true;
                            txtCanNotes.Text = r[3].ToString();
                            int yearfrom = int.Parse(txtCanNotes.Text);
                            int yrs = yeartoday - yearfrom;
                            TextBox13.Text = yrs.ToString();

                        }
                    }
                }
            }





        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["smrn"] != null)
            {
                Console.WriteLine("Session ok");
                string val = Session["smrn"].ToString();

                string historytype = "PMH";

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

                //con.Open();
                //SqlCommand cmd = new SqlCommand("delete from Medical_history where patient_id=" + val + " and history_type='PMH'", con);
                //cmd.ExecuteNonQuery();
                //con.Close();
                //SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type1)", con);
                if (CheckBox1.Checked)
                {
                    cmd1.Parameters.AddWithValue("@patient_id1", val);
                    cmd1.Parameters.AddWithValue("@code1", "Diabetes");
                    String valn = "yes";
                    cmd1.Parameters.AddWithValue("@value1", valn);
                    cmd1.Parameters.AddWithValue("@note1", txtDiabNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd1.Parameters.AddWithValue("@datestamp1", d);
                    cmd1.Parameters.AddWithValue("@history_type1", historytype);
                    cmd1.ExecuteNonQuery();
                }
                SqlCommand cmd2 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type2)", con);
                if (CheckBox3.Checked)
                {
                    cmd2.Parameters.AddWithValue("@patient_id2", val);
                    cmd2.Parameters.AddWithValue("@code2", "Hypertension");
                    String valn = "yes";
                    cmd2.Parameters.AddWithValue("@value2", valn);
                    cmd2.Parameters.AddWithValue("@note2", txtHyperNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd2.Parameters.AddWithValue("@datestamp2", d);
                    cmd2.Parameters.AddWithValue("@history_type2", historytype);
                    cmd2.ExecuteNonQuery();
                }
                if (CheckBox5.Checked)
                {
                    SqlCommand cmd3 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id3,@code3,@value3,@note3,@datestamp3,@history_type3)", con);
                    cmd3.Parameters.AddWithValue("@patient_id3", val);
                    cmd3.Parameters.AddWithValue("@code3", "MI");
                    String valn = "yes";
                    cmd3.Parameters.AddWithValue("@value3", valn);
                    cmd3.Parameters.AddWithValue("@note3", txtMINotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd3.Parameters.AddWithValue("@datestamp3", d);
                    cmd3.Parameters.AddWithValue("@history_type3", historytype);
                    cmd3.ExecuteNonQuery();
                }
                if (CheckBox7.Checked)
                {
                    SqlCommand cmd4 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type4)", con);
                    cmd4.Parameters.AddWithValue("@patient_id4", val);
                    cmd4.Parameters.AddWithValue("@code4", "Stroke");
                    String valn = "yes";
                    cmd4.Parameters.AddWithValue("@value4", valn);
                    cmd4.Parameters.AddWithValue("@note4", txtStrokeNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd4.Parameters.AddWithValue("@datestamp4", d);
                    cmd4.Parameters.AddWithValue("@history_type4", historytype);
                    cmd4.ExecuteNonQuery();
                }
                if (CheckBox9.Checked)
                {
                    SqlCommand cmd5 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id5,@code5,@value5,@note5,@datestamp5,@history_type5)", con);
                    cmd5.Parameters.AddWithValue("@patient_id5", val);
                    cmd5.Parameters.AddWithValue("@code5", "Hepatitis");
                    String valn = "yes";
                    cmd5.Parameters.AddWithValue("@value5", valn);
                    cmd5.Parameters.AddWithValue("@note5", txtHepaNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd5.Parameters.AddWithValue("@datestamp5", d);
                    cmd5.Parameters.AddWithValue("@history_type5", historytype);
                    cmd5.ExecuteNonQuery();
                }
                if (CheckBox11.Checked)
                {
                    SqlCommand cmd6 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id6,@code6,@value6,@note6,@datestamp6,@history_type6)", con);
                    cmd6.Parameters.AddWithValue("@patient_id6", val);
                    cmd6.Parameters.AddWithValue("@code6", "Kidney Stones");
                    String valn = "yes";
                    cmd6.Parameters.AddWithValue("@value6", valn);
                    cmd6.Parameters.AddWithValue("@note6", txtKidStoNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd6.Parameters.AddWithValue("@datestamp6", d);
                    cmd6.Parameters.AddWithValue("@history_type6", historytype);
                    cmd6.ExecuteNonQuery();
                }
                if (CheckBox13.Checked)
                {
                    SqlCommand cmd7 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id7,@code7,@value7,@note7,@datestamp7,@history_type7)", con);
                    cmd7.Parameters.AddWithValue("@patient_id7", val);
                    cmd7.Parameters.AddWithValue("@code7", "Asthma");
                    String valn = "yes";
                    cmd7.Parameters.AddWithValue("@value7", valn);
                    cmd7.Parameters.AddWithValue("@note7", txtAsthNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd7.Parameters.AddWithValue("@datestamp7", d);
                    cmd7.Parameters.AddWithValue("@history_type7", historytype);
                    cmd7.ExecuteNonQuery();
                }
                if (CheckBox15.Checked)
                {
                    SqlCommand cmd8 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id8,@code8,@value8,@note8,@datestamp8,@history_type8)", con);
                    cmd8.Parameters.AddWithValue("@patient_id8", val);
                    cmd8.Parameters.AddWithValue("@code8", "Kidney Disease");
                    String valn = "yes";
                    cmd8.Parameters.AddWithValue("@value8", valn);
                    cmd8.Parameters.AddWithValue("@note8", txtKidDisNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd8.Parameters.AddWithValue("@datestamp8", d);
                    cmd8.Parameters.AddWithValue("@history_type8", historytype);
                    cmd8.ExecuteNonQuery();
                }
                if (CheckBox17.Checked)
                {
                    SqlCommand cmd9 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id9,@code9,@value9,@note9,@datestamp9,@history_type9)", con);
                    cmd9.Parameters.AddWithValue("@patient_id9", val);
                    cmd9.Parameters.AddWithValue("@code9", "Prostate Cancer");
                    String valn = "yes";
                    cmd9.Parameters.AddWithValue("@value9", valn);
                    cmd9.Parameters.AddWithValue("@note9", txtProsCanNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd9.Parameters.AddWithValue("@datestamp9", d);
                    cmd9.Parameters.AddWithValue("@history_type9", historytype);
                    cmd9.ExecuteNonQuery();
                }
                if (CheckBox19.Checked)
                {
                    SqlCommand cmd10 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id10,@code10,@value10,@note10,@datestamp10,@history_type10)", con);
                    cmd10.Parameters.AddWithValue("@patient_id10", val);
                    cmd10.Parameters.AddWithValue("@code10", "Urinary Cancer");
                    String valn = "yes";
                    cmd10.Parameters.AddWithValue("@value10", valn);
                    cmd10.Parameters.AddWithValue("@note10", txtUriNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd10.Parameters.AddWithValue("@datestamp10", d);
                    cmd10.Parameters.AddWithValue("@history_type10", historytype);
                    cmd10.ExecuteNonQuery();
                }
                if (CheckBox21.Checked)
                {
                    SqlCommand cmd11 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id11,@code11,@value11,@note11,@datestamp11,@history_type11)", con);
                    cmd11.Parameters.AddWithValue("@patient_id11", val);
                    cmd11.Parameters.AddWithValue("@code11", "Epilpsy");
                    String valn = "yes";
                    cmd11.Parameters.AddWithValue("@value11", valn);
                    cmd11.Parameters.AddWithValue("@note11", txtEpilNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd11.Parameters.AddWithValue("@datestamp11", d);
                    cmd11.Parameters.AddWithValue("@history_type11", historytype);
                    cmd11.ExecuteNonQuery();
                }
                if (CheckBox23.Checked)
                {
                    SqlCommand cmd12 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id12,@code12,@value12,@note12,@datestamp12,@history_type12)", con);
                    cmd12.Parameters.AddWithValue("@patient_id12", val);
                    cmd12.Parameters.AddWithValue("@code12", "Cancer");
                    String valn = "yes";
                    cmd12.Parameters.AddWithValue("@value12", valn);
                    cmd12.Parameters.AddWithValue("@note12", txtCanNotes.Text);
                    string d = DateTime.Now.ToString();
                    cmd12.Parameters.AddWithValue("@datestamp12", d);
                    cmd12.Parameters.AddWithValue("@history_type12", historytype);
                    cmd12.ExecuteNonQuery();
                }

                con.Close();
            }

            Console.WriteLine("session not ok00");
        }


        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            string prev = Session["hom"].ToString();
            if (txtHOM.Text == "HOM" && prev == "DOC")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            if (txtHOM.Text == "HOM" && prev == "MA")
            {
                txtHOM.Text = "";
                Response.Redirect("MADashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}
   

        
    
