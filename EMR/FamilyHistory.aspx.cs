using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class FamHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            LoadFH();
        }
        protected void LoadFH()
        {
            if (Session["smrn"] != null)
            {
                string v = Session["smrn"].ToString();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Medical_history where patient_id=" + v + " and history_type='FH' ", con);

                int yeartoday = DateTime.Now.Year;
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        if (r.GetValue(1).ToString() == "Diabetes" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox1.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Diabetes" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox2.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Diabetes" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox3.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Diabetes" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox4.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hypertension" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox5.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hypertension" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox6.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hypertension" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox7.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hypertension" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox8.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "MI" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox9.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "MI" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox10.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "MI" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox11.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "MI" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox12.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Stroke" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox13.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Stroke" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox14.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Stroke" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox15.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Stroke" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox16.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hepatitis" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox17.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hepatitis" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox18.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hepatitis" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox19.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Hepatitis" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox20.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Stones" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox21.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Stones" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox22.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Stones" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox23.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Stones" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox24.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Lung Disease" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox25.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Lung Disease" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox26.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Lung Disease" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox27.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Lung Disease" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox28.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Disease" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox29.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Disease" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox30.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Disease" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox31.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Kidney Disease" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox32.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Prostate Cancer" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox33.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Prostate Cancer" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox34.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Prostate Cancer" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox35.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Prostate Cancer" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox36.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Cancer" && r.GetValue(3).ToString() == "Patient")
                        {
                            CheckBox37.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Cancer" && r.GetValue(3).ToString() == "Father")
                        {
                            CheckBox38.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Cancer" && r.GetValue(3).ToString() == "Mother")
                        {
                            CheckBox39.Checked = true;
                        }
                        if (r.GetValue(1).ToString() == "Cancer" && r.GetValue(3).ToString() == "Sibling")
                        {
                            CheckBox40.Checked = true;
                        }
                    }
                }
                if (!r.HasRows)
                {

                }
                con.Close();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string val = Session["smrn"].ToString();
            string historytype = "FH";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            

            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Medical_history where patient_id=" + val + " and history_type='FH'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadFH();
            con.Open();
            if (CheckBox1.Checked == true)
            {
                SqlCommand cmd1 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type1)", con);

                cmd1.Parameters.AddWithValue("@patient_id1", val);
                cmd1.Parameters.AddWithValue("@code1", "Diabetes");
                string yesorno = "yes";
                cmd1.Parameters.AddWithValue("@value1", yesorno);
                cmd1.Parameters.AddWithValue("@note1", "Patient");
                string d = DateTime.Now.ToString();
                cmd1.Parameters.AddWithValue("@datestamp1", d);
                cmd1.Parameters.AddWithValue("@history_type1", historytype);
                cmd1.ExecuteNonQuery();
            }
            if (CheckBox2.Checked == true)
            {
                SqlCommand cmd2 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type2)", con);
                cmd2.Parameters.AddWithValue("@patient_id2", val);
                cmd2.Parameters.AddWithValue("@code2", "Diabetes");
                string yesorno = "yes";
                cmd2.Parameters.AddWithValue("@value2", yesorno);
                cmd2.Parameters.AddWithValue("@note2","Father");
                string d = DateTime.Now.ToString();
                cmd2.Parameters.AddWithValue("@datestamp2", d);
                cmd2.Parameters.AddWithValue("@history_type2", historytype);
                cmd2.ExecuteNonQuery();
            }
            if (CheckBox3.Checked == true)
            {
                SqlCommand cmd3 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id3,@code3,@value3,@note3,@datestamp3,@history_type3)", con);

                cmd3.Parameters.AddWithValue("@patient_id3", val);
                cmd3.Parameters.AddWithValue("@code3", "Diabetes");
                string yesorno = "yes";
                cmd3.Parameters.AddWithValue("@value3", yesorno);
                cmd3.Parameters.AddWithValue("@note3","Mother");
                string d = DateTime.Now.ToString();
                cmd3.Parameters.AddWithValue("@datestamp3", d);
                cmd3.Parameters.AddWithValue("@history_type3", historytype);
                cmd3.ExecuteNonQuery();
            }
            if (CheckBox4.Checked == true)
            {
                SqlCommand cmd4 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type4)", con);

                cmd4.Parameters.AddWithValue("@patient_id4", val);
                cmd4.Parameters.AddWithValue("@code4", "Diabetes");
                string yesorno = "yes";
                cmd4.Parameters.AddWithValue("@value4", yesorno);
                cmd4.Parameters.AddWithValue("@note4","Sibling");
                string d = DateTime.Now.ToString();
                cmd4.Parameters.AddWithValue("@datestamp4", d);
                cmd4.Parameters.AddWithValue("@history_type4", historytype);
                cmd4.ExecuteNonQuery();
            }
            if (CheckBox5.Checked == true)
            {
                SqlCommand cmd5 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id5,@code5,@value5,@note5,@datestamp5,@history_type5)", con);

                cmd5.Parameters.AddWithValue("@patient_id5", val);
                cmd5.Parameters.AddWithValue("@code5", "Hypertension");
                string yesorno = "yes";
                cmd5.Parameters.AddWithValue("@value5", yesorno);
                cmd5.Parameters.AddWithValue("@note5", "Patient");
                string d = DateTime.Now.ToString();
                cmd5.Parameters.AddWithValue("@datestamp5", d);
                cmd5.Parameters.AddWithValue("@history_type5", historytype);
                cmd5.ExecuteNonQuery();
            }
            if (CheckBox6.Checked == true)
            {
                SqlCommand cmd6 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id6,@code6,@value6,@note6,@datestamp6,@history_type6)", con);
                cmd6.Parameters.AddWithValue("@patient_id6", val);
                cmd6.Parameters.AddWithValue("@code6", "Hypertension");
                string yesorno = "yes";
                cmd6.Parameters.AddWithValue("@value6", yesorno);
                cmd6.Parameters.AddWithValue("@note6", "Father");
                string d = DateTime.Now.ToString();
                cmd6.Parameters.AddWithValue("@datestamp6", d);
                cmd6.Parameters.AddWithValue("@history_type6", historytype);
                cmd6.ExecuteNonQuery();
            }
            if (CheckBox7.Checked == true)
            {
                SqlCommand cmd7 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id7,@code7,@value7,@note7,@datestamp7,@history_type7)", con);

                cmd7.Parameters.AddWithValue("@patient_id7", val);
                cmd7.Parameters.AddWithValue("@code7", "Hypertension");
                string yesorno = "yes";
                cmd7.Parameters.AddWithValue("@value7", yesorno);
                cmd7.Parameters.AddWithValue("@note7", "Mother");
                string d = DateTime.Now.ToString();
                cmd7.Parameters.AddWithValue("@datestamp7", d);
                cmd7.Parameters.AddWithValue("@history_type7", historytype);
                cmd7.ExecuteNonQuery();
            }
            if (CheckBox8.Checked == true)
            {
                SqlCommand cmd8 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id8,@code8,@value8,@note8,@datestamp8,@history_type8)", con);

                cmd8.Parameters.AddWithValue("@patient_id8", val);
                cmd8.Parameters.AddWithValue("@code8", "Hypertension");
                string yesorno = "yes";
                cmd8.Parameters.AddWithValue("@value8", yesorno);
                cmd8.Parameters.AddWithValue("@note8", "Sibling");
                string d = DateTime.Now.ToString();
                cmd8.Parameters.AddWithValue("@datestamp8", d);
                cmd8.Parameters.AddWithValue("@history_type8", historytype);
                cmd8.ExecuteNonQuery();
            }
            if (CheckBox9.Checked == true)
            {
                SqlCommand cmd9 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id9,@code9,@value9,@note9,@datestamp9,@history_type9)", con);

                cmd9.Parameters.AddWithValue("@patient_id9", val);
                cmd9.Parameters.AddWithValue("@code9", "MI");
                string yesorno = "yes";
                cmd9.Parameters.AddWithValue("@value9", yesorno);
                cmd9.Parameters.AddWithValue("@note9", "Patient");
                string d = DateTime.Now.ToString();
                cmd9.Parameters.AddWithValue("@datestamp9", d);
                cmd9.Parameters.AddWithValue("@history_type9", historytype);
                cmd9.ExecuteNonQuery();
            }
            if (CheckBox10.Checked == true)
            {
                SqlCommand cmd10 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id10,@code10,@value10,@note10,@datestamp10,@history_type10)", con);
                cmd10.Parameters.AddWithValue("@patient_id10", val);
                cmd10.Parameters.AddWithValue("@code10", "MI");
                string yesorno = "yes";
                cmd10.Parameters.AddWithValue("@value10", yesorno);
                cmd10.Parameters.AddWithValue("@note10", "Father");
                string d = DateTime.Now.ToString();
                cmd10.Parameters.AddWithValue("@datestamp10", d);
                cmd10.Parameters.AddWithValue("@history_type10", historytype);
                cmd10.ExecuteNonQuery();
            }
            if (CheckBox11.Checked == true)
            {
                SqlCommand cmd11 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id11,@code11,@value11,@note11,@datestamp11,@history_type11)", con);

                cmd11.Parameters.AddWithValue("@patient_id11", val);
                cmd11.Parameters.AddWithValue("@code11", "MI");
                string yesorno = "yes";
                cmd11.Parameters.AddWithValue("@value11", yesorno);
                cmd11.Parameters.AddWithValue("@note11", "Mother");
                string d = DateTime.Now.ToString();
                cmd11.Parameters.AddWithValue("@datestamp11", d);
                cmd11.Parameters.AddWithValue("@history_type11", historytype);
                cmd11.ExecuteNonQuery();
            }
            if (CheckBox12.Checked == true)
            {
                SqlCommand cmd12 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id12,@code12,@value12,@note12,@datestamp12,@history_type12)", con);

                cmd12.Parameters.AddWithValue("@patient_id12", val);
                cmd12.Parameters.AddWithValue("@code12", "MI");
                string yesorno = "yes";
                cmd12.Parameters.AddWithValue("@value12", yesorno);
                cmd12.Parameters.AddWithValue("@note12", "Sibling");
                string d = DateTime.Now.ToString();
                cmd12.Parameters.AddWithValue("@datestamp12", d);
                cmd12.Parameters.AddWithValue("@history_type12", historytype);
                cmd12.ExecuteNonQuery();
            }
            if (CheckBox13.Checked == true)
            {
                SqlCommand cmd13 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id13,@code13,@value13,@note13,@datestamp13,@history_type13)", con);

                cmd13.Parameters.AddWithValue("@patient_id13", val);
                cmd13.Parameters.AddWithValue("@code13", "Stroke");
                string yesorno = "yes";
                cmd13.Parameters.AddWithValue("@value13", yesorno);
                cmd13.Parameters.AddWithValue("@note13", "Patient");
                string d = DateTime.Now.ToString();
                cmd13.Parameters.AddWithValue("@datestamp13", d);
                cmd13.Parameters.AddWithValue("@history_type13", historytype);
                cmd13.ExecuteNonQuery();
            }
            if (CheckBox14.Checked == true)
            {
                SqlCommand cmd14 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id14,@code14,@value14,@note14,@datestamp14,@history_type14)", con);
                cmd14.Parameters.AddWithValue("@patient_id14", val);
                cmd14.Parameters.AddWithValue("@code14", "Stroke");
                string yesorno = "yes";
                cmd14.Parameters.AddWithValue("@value14", yesorno);
                cmd14.Parameters.AddWithValue("@note14", "Father");
                string d = DateTime.Now.ToString();
                cmd14.Parameters.AddWithValue("@datestamp14", d);
                cmd14.Parameters.AddWithValue("@history_type14", historytype);
                cmd14.ExecuteNonQuery();
            }
            if (CheckBox15.Checked == true)
            {
                SqlCommand cmd15 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id15,@code15,@value15,@note15,@datestamp15,@history_type15)", con);

                cmd15.Parameters.AddWithValue("@patient_id15", val);
                cmd15.Parameters.AddWithValue("@code15", "Stroke");
                string yesorno = "yes";
                cmd15.Parameters.AddWithValue("@value15", yesorno);
                cmd15.Parameters.AddWithValue("@note15", "Mother");
                string d = DateTime.Now.ToString();
                cmd15.Parameters.AddWithValue("@datestamp15", d);
                cmd15.Parameters.AddWithValue("@history_type15", historytype);
                cmd15.ExecuteNonQuery();
            }
            if (CheckBox16.Checked == true)
            {
                SqlCommand cmd16 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id16,@code16,@value16,@note16,@datestamp16,@history_type16)", con);

                cmd16.Parameters.AddWithValue("@patient_id16", val);
                cmd16.Parameters.AddWithValue("@code16", "Stroke");
                string yesorno = "yes";
                cmd16.Parameters.AddWithValue("@value16", yesorno);
                cmd16.Parameters.AddWithValue("@note16", "Sibling");
                string d = DateTime.Now.ToString();
                cmd16.Parameters.AddWithValue("@datestamp16", d);
                cmd16.Parameters.AddWithValue("@history_type16", historytype);
                cmd16.ExecuteNonQuery();
            }
            if (CheckBox17.Checked == true)
            {
                SqlCommand cmd17 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id17,@code17,@value17,@note17,@datestamp17,@history_type17)", con);

                cmd17.Parameters.AddWithValue("@patient_id17", val);
                cmd17.Parameters.AddWithValue("@code17", "Hepatitis");
                string yesorno = "yes";
                cmd17.Parameters.AddWithValue("@value17", yesorno);
                cmd17.Parameters.AddWithValue("@note17", "Patient");
                string d = DateTime.Now.ToString();
                cmd17.Parameters.AddWithValue("@datestamp17", d);
                cmd17.Parameters.AddWithValue("@history_type17", historytype);
                cmd17.ExecuteNonQuery();
            }
            if (CheckBox18.Checked == true)
            {
                SqlCommand cmd18 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id18,@code18,@value18,@note18,@datestamp18,@history_type18)", con);
                cmd18.Parameters.AddWithValue("@patient_id18", val);
                cmd18.Parameters.AddWithValue("@code18", "Hepatitis");
                string yesorno = "yes";
                cmd18.Parameters.AddWithValue("@value18", yesorno);
                cmd18.Parameters.AddWithValue("@note18", "Father");
                string d = DateTime.Now.ToString();
                cmd18.Parameters.AddWithValue("@datestamp18", d);
                cmd18.Parameters.AddWithValue("@history_type18", historytype);
                cmd18.ExecuteNonQuery();
            }
            if (CheckBox19.Checked == true)
            {
                SqlCommand cmd19 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id19,@code19,@value19,@note19,@datestamp19,@history_type19)", con);

                cmd19.Parameters.AddWithValue("@patient_id19", val);
                cmd19.Parameters.AddWithValue("@code19", "Hepatitis");
                string yesorno = "yes";
                cmd19.Parameters.AddWithValue("@value19", yesorno);
                cmd19.Parameters.AddWithValue("@note19", "Mother");
                string d = DateTime.Now.ToString();
                cmd19.Parameters.AddWithValue("@datestamp19", d);
                cmd19.Parameters.AddWithValue("@history_type19", historytype);
                cmd19.ExecuteNonQuery();
            }
            if (CheckBox20.Checked == true)
            {
                SqlCommand cmd20 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id20,@code20,@value20,@note20,@datestamp20,@history_type20)", con);

                cmd20.Parameters.AddWithValue("@patient_id20", val);
                cmd20.Parameters.AddWithValue("@code20", "Hepatitis");
                string yesorno = "yes";
                cmd20.Parameters.AddWithValue("@value20", yesorno);
                cmd20.Parameters.AddWithValue("@note20", "Sibling");
                string d = DateTime.Now.ToString();
                cmd20.Parameters.AddWithValue("@datestamp20", d);
                cmd20.Parameters.AddWithValue("@history_type20", historytype);
                cmd20.ExecuteNonQuery();
            }
            if (CheckBox21.Checked == true)
            {
                SqlCommand cmd21 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id21,@code21,@value21,@note21,@datestamp21,@history_type21)", con);

                cmd21.Parameters.AddWithValue("@patient_id21", val);
                cmd21.Parameters.AddWithValue("@code21", "Kidney Stones");
                string yesorno = "yes";
                cmd21.Parameters.AddWithValue("@value21", yesorno);
                cmd21.Parameters.AddWithValue("@note21", "Patient");
                string d = DateTime.Now.ToString();
                cmd21.Parameters.AddWithValue("@datestamp21", d);
                cmd21.Parameters.AddWithValue("@history_type21", historytype);
                cmd21.ExecuteNonQuery();
            }
            if (CheckBox22.Checked == true)
            {
                SqlCommand cmd22 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id22,@code22,@value22,@note22,@datestamp22,@history_type22)", con);

                cmd22.Parameters.AddWithValue("@patient_id22", val);
                cmd22.Parameters.AddWithValue("@code22", "Kidney Stones");
                string yesorno = "yes";
                cmd22.Parameters.AddWithValue("@value22", yesorno);
                cmd22.Parameters.AddWithValue("@note22", "Father");
                string d = DateTime.Now.ToString();
                cmd22.Parameters.AddWithValue("@datestamp22", d);
                cmd22.Parameters.AddWithValue("@history_type22", historytype);
                cmd22.ExecuteNonQuery();
            }
            if (CheckBox23.Checked == true)
            {
                SqlCommand cmd23 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id23,@code23,@value23,@note23,@datestamp23,@history_type23)", con);

                cmd23.Parameters.AddWithValue("@patient_id23", val);
                cmd23.Parameters.AddWithValue("@code23", "Kidney Stones");
                string yesorno = "yes";
                cmd23.Parameters.AddWithValue("@value23", yesorno);
                cmd23.Parameters.AddWithValue("@note23", "Mother");
                string d = DateTime.Now.ToString();
                cmd23.Parameters.AddWithValue("@datestamp23", d);
                cmd23.Parameters.AddWithValue("@history_type23", historytype);
                cmd23.ExecuteNonQuery();
            }
            if (CheckBox24.Checked == true)
            {
                SqlCommand cmd24 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id24,@code24,@value24,@note24,@datestamp24,@history_type24)", con);

                cmd24.Parameters.AddWithValue("@patient_id24", val);
                cmd24.Parameters.AddWithValue("@code24", "Kidney Stones");
                string yesorno = "yes";
                cmd24.Parameters.AddWithValue("@value24", yesorno);
                cmd24.Parameters.AddWithValue("@note24", "Sibling");
                string d = DateTime.Now.ToString();
                cmd24.Parameters.AddWithValue("@datestamp24", d);
                cmd24.Parameters.AddWithValue("@history_type24", historytype);
                cmd24.ExecuteNonQuery();
            }
            if (CheckBox25.Checked == true)
            {
                SqlCommand cmd25 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id25,@code25,@value25,@note25,@datestamp25,@history_type25)", con);

                cmd25.Parameters.AddWithValue("@patient_id25", val);
                cmd25.Parameters.AddWithValue("@code25", "Lung Disease");
                string yesorno = "yes";
                cmd25.Parameters.AddWithValue("@value25", yesorno);
                cmd25.Parameters.AddWithValue("@note25", "Patient");
                string d = DateTime.Now.ToString();
                cmd25.Parameters.AddWithValue("@datestamp25", d);
                cmd25.Parameters.AddWithValue("@history_type25", historytype);
                cmd25.ExecuteNonQuery();
            }
            if (CheckBox26.Checked == true)
            {
                SqlCommand cmd26 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id26,@code26,@value26,@note26,@datestamp26,@history_type26)", con);

                cmd26.Parameters.AddWithValue("@patient_id26", val);
                cmd26.Parameters.AddWithValue("@code26", "Lung Disease");
                string yesorno = "yes";
                cmd26.Parameters.AddWithValue("@value26", yesorno);
                cmd26.Parameters.AddWithValue("@note26", "Father");
                string d = DateTime.Now.ToString();
                cmd26.Parameters.AddWithValue("@datestamp26", d);
                cmd26.Parameters.AddWithValue("@history_type26", historytype);
                cmd26.ExecuteNonQuery();
            }
            if (CheckBox27.Checked == true)
            {
                SqlCommand cmd27 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id27,@code27,@value27,@note27,@datestamp27,@history_type27)", con);

                cmd27.Parameters.AddWithValue("@patient_id27", val);
                cmd27.Parameters.AddWithValue("@code27", "Lung Disease");
                string yesorno = "yes";
                cmd27.Parameters.AddWithValue("@value27", yesorno);
                cmd27.Parameters.AddWithValue("@note27", "Mother");
                string d = DateTime.Now.ToString();
                cmd27.Parameters.AddWithValue("@datestamp27", d);
                cmd27.Parameters.AddWithValue("@history_type27", historytype);
                cmd27.ExecuteNonQuery();
            }
            if (CheckBox28.Checked == true)
            {
                SqlCommand cmd28 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id28,@code28,@value28,@note28,@datestamp28,@history_type28)", con);

                cmd28.Parameters.AddWithValue("@patient_id28", val);
                cmd28.Parameters.AddWithValue("@code28", "Lung Disease");
                string yesorno = "yes";
                cmd28.Parameters.AddWithValue("@value28", yesorno);
                cmd28.Parameters.AddWithValue("@note28", "Sibling");
                string d = DateTime.Now.ToString();
                cmd28.Parameters.AddWithValue("@datestamp28", d);
                cmd28.Parameters.AddWithValue("@history_type28", historytype);
                cmd28.ExecuteNonQuery();
            }
            if (CheckBox29.Checked == true)
            {
                SqlCommand cmd29 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id29,@code29,@value29,@note29,@datestamp29,@history_type29)", con);

                cmd29.Parameters.AddWithValue("@patient_id29", val);
                cmd29.Parameters.AddWithValue("@code29", "Kidney Disease");
                string yesorno = "yes";
                cmd29.Parameters.AddWithValue("@value29", yesorno);
                cmd29.Parameters.AddWithValue("@note29", "Patient");
                string d = DateTime.Now.ToString();
                cmd29.Parameters.AddWithValue("@datestamp29", d);
                cmd29.Parameters.AddWithValue("@history_type29", historytype);
                cmd29.ExecuteNonQuery();
            }
            if (CheckBox30.Checked == true)
            {
                SqlCommand cmd30 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id30,@code30,@value30,@note30,@datestamp30,@history_type30)", con);

                cmd30.Parameters.AddWithValue("@patient_id30", val);
                cmd30.Parameters.AddWithValue("@code30", "Kidney Disease");
                string yesorno = "yes";
                cmd30.Parameters.AddWithValue("@value30", yesorno);
                cmd30.Parameters.AddWithValue("@note30", "Father");
                string d = DateTime.Now.ToString();
                cmd30.Parameters.AddWithValue("@datestamp30", d);
                cmd30.Parameters.AddWithValue("@history_type30", historytype);
                cmd30.ExecuteNonQuery();
            }
            if (CheckBox31.Checked == true)
            {
                SqlCommand cmd31 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id31,@code31,@value31,@note31,@datestamp31,@history_type31)", con);

                cmd31.Parameters.AddWithValue("@patient_id31", val);
                cmd31.Parameters.AddWithValue("@code31", "Kidney Disease");
                string yesorno = "yes";
                cmd31.Parameters.AddWithValue("@value31", yesorno);
                cmd31.Parameters.AddWithValue("@note31", "Mother");
                string d = DateTime.Now.ToString();
                cmd31.Parameters.AddWithValue("@datestamp31", d);
                cmd31.Parameters.AddWithValue("@history_type31", historytype);
                cmd31.ExecuteNonQuery();
            }
            if (CheckBox32.Checked == true)
            {
                SqlCommand cmd32 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id32,@code32,@value32,@note32,@datestamp32,@history_type32)", con);

                cmd32.Parameters.AddWithValue("@patient_id32", val);
                cmd32.Parameters.AddWithValue("@code32", "Kidney Disease");
                string yesorno = "yes";
                cmd32.Parameters.AddWithValue("@value32", yesorno);
                cmd32.Parameters.AddWithValue("@note32", "Sibling");
                string d = DateTime.Now.ToString();
                cmd32.Parameters.AddWithValue("@datestamp32", d);
                cmd32.Parameters.AddWithValue("@history_type32", historytype);
                cmd32.ExecuteNonQuery();
            }
            if (CheckBox33.Checked == true)
            {
                SqlCommand cmd33 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id33,@code33,@value33,@note33,@datestamp33,@history_type33)", con);

                cmd33.Parameters.AddWithValue("@patient_id33", val);
                cmd33.Parameters.AddWithValue("@code33", "Prostate Cancer");
                string yesorno = "yes";
                cmd33.Parameters.AddWithValue("@value33", yesorno);
                cmd33.Parameters.AddWithValue("@note33", "Patient");
                string d = DateTime.Now.ToString();
                cmd33.Parameters.AddWithValue("@datestamp33", d);
                cmd33.Parameters.AddWithValue("@history_type33", historytype);
                cmd33.ExecuteNonQuery();
            }
            if (CheckBox34.Checked == true)
            {
                SqlCommand cmd34 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id34,@code34,@value34,@note34,@datestamp34,@history_type34)", con);

                cmd34.Parameters.AddWithValue("@patient_id34", val);
                cmd34.Parameters.AddWithValue("@code34", "Prostate Cancer");
                string yesorno = "yes";
                cmd34.Parameters.AddWithValue("@value34", yesorno);
                cmd34.Parameters.AddWithValue("@note34", "Father");
                string d = DateTime.Now.ToString();
                cmd34.Parameters.AddWithValue("@datestamp34", d);
                cmd34.Parameters.AddWithValue("@history_type34", historytype);
                cmd34.ExecuteNonQuery();
            }
            if (CheckBox35.Checked == true)
            {
                SqlCommand cmd35 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id35,@code35,@value35,@note35,@datestamp35,@history_type35)", con);

                cmd35.Parameters.AddWithValue("@patient_id35", val);
                cmd35.Parameters.AddWithValue("@code35", "Prostate Cancer");
                string yesorno = "yes";
                cmd35.Parameters.AddWithValue("@value35", yesorno);
                cmd35.Parameters.AddWithValue("@note35", "Mother");
                string d = DateTime.Now.ToString();
                cmd35.Parameters.AddWithValue("@datestamp35", d);
                cmd35.Parameters.AddWithValue("@history_type35", historytype);
                cmd35.ExecuteNonQuery();
            }
            if (CheckBox36.Checked == true)
            {
                SqlCommand cmd36 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id36,@code36,@value36,@note36,@datestamp36,@history_type36)", con);

                cmd36.Parameters.AddWithValue("@patient_id36", val);
                cmd36.Parameters.AddWithValue("@code36", "Prostate Cancer");
                string yesorno = "yes";
                cmd36.Parameters.AddWithValue("@value36", yesorno);
                cmd36.Parameters.AddWithValue("@note36", "Sibling");
                string d = DateTime.Now.ToString();
                cmd36.Parameters.AddWithValue("@datestamp36", d);
                cmd36.Parameters.AddWithValue("@history_type36", historytype);
                cmd36.ExecuteNonQuery();
            }
            if (CheckBox37.Checked == true)
            {
                SqlCommand cmd37 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id37,@code37,@value37,@note37,@datestamp37,@history_type37)", con);

                cmd37.Parameters.AddWithValue("@patient_id37", val);
                cmd37.Parameters.AddWithValue("@code37", "Cancer");
                string yesorno = "yes";
                cmd37.Parameters.AddWithValue("@value37", yesorno);
                cmd37.Parameters.AddWithValue("@note37", "Patient");
                string d = DateTime.Now.ToString();
                cmd37.Parameters.AddWithValue("@datestamp37", d);
                cmd37.Parameters.AddWithValue("@history_type37", historytype);
                cmd37.ExecuteNonQuery();
            }
            if (CheckBox38.Checked == true)
            {
                SqlCommand cmd38 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id38,@code38,@value38,@note38,@datestamp38,@history_type38)", con);

                cmd38.Parameters.AddWithValue("@patient_id38", val);
                cmd38.Parameters.AddWithValue("@code38", "Cancer");
                string yesorno = "yes";
                cmd38.Parameters.AddWithValue("@value38", yesorno);
                cmd38.Parameters.AddWithValue("@note38", "Father");
                string d = DateTime.Now.ToString();
                cmd38.Parameters.AddWithValue("@datestamp38", d);
                cmd38.Parameters.AddWithValue("@history_type38", historytype);
                cmd38.ExecuteNonQuery();
            }
            if (CheckBox39.Checked == true)
            {
                SqlCommand cmd39 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id39,@code39,@value39,@note39,@datestamp39,@history_type39)", con);

                cmd39.Parameters.AddWithValue("@patient_id39", val);
                cmd39.Parameters.AddWithValue("@code39", "Cancer");
                string yesorno = "yes";
                cmd39.Parameters.AddWithValue("@value39", yesorno);
                cmd39.Parameters.AddWithValue("@note39", "Mother");
                string d = DateTime.Now.ToString();
                cmd39.Parameters.AddWithValue("@datestamp39", d);
                cmd39.Parameters.AddWithValue("@history_type39", historytype);
                cmd39.ExecuteNonQuery();
            }
            if (CheckBox40.Checked == true)
            {
                SqlCommand cmd40 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id40,@code40,@value40,@note40,@datestamp40,@history_type40)", con);

                cmd40.Parameters.AddWithValue("@patient_id40", val);
                cmd40.Parameters.AddWithValue("@code40", "Cancer");
                string yesorno = "yes";
                cmd40.Parameters.AddWithValue("@value40", yesorno);
                cmd40.Parameters.AddWithValue("@note40", "Sibling");
                string d = DateTime.Now.ToString();
                cmd40.Parameters.AddWithValue("@datestamp40", d);
                cmd40.Parameters.AddWithValue("@history_type40", historytype);
                cmd40.ExecuteNonQuery();
            }
            con.Close();
           

        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (Session["hom"] != null)
            {
                string prev = Session["hom"].ToString();
                if (txtHOM.Text == "HOM" && prev == "DOC")
                {
                    Response.Redirect("DoctorDashboard.aspx");
                }
                else if (txtHOM.Text == "HOM" && prev == "MA")
                {
                    Response.Redirect("MADashboard.aspx");
                }
            }
        }
    }
}