using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class SocialHistory : System.Web.UI.Page
    {
        private readonly string connectionString = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtHOM.Focus();
                LoadSocialHistory();
            }
        }

        protected void LoadSocialHistory()
        {
            if (Session["smrn"] != null)
            {
                string patientId = Session["smrn"].ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT code, value, note FROM Medical_history WHERE patient_id=@patientId AND history_type='SH'", con);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string code = reader.GetString(0);
                            string value = reader.GetString(1);
                            string note = reader.GetString(2);

                            switch (code)
                            {
                                case "MarSt":
                                    ChkMar.Checked = (value == "Married");
                                    ChkSin.Checked = (value == "Single");
                                    break;
                                case "Smok":
                                    chkSm.Checked = (value == "Smoking");
                                    chkNSm.Checked = (value == "Non Smoking");
                                    txtYears.Text = note;
                                    break;
                                case "Dru":
                                    chkDru.Checked = (value == "Drugs");
                                    chkNDru.Checked = (value == "No Drugs");
                                    txtAlFreq.Text = note;
                                    break;
                                case "Alco":
                                    chkAlc.Checked = (value == "Alcohol");
                                    chkNAlc.Checked = (value == "Non Alcohol");
                                    break;
                            }
                        }
                    }

                    con.Close();
                }
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string val = Session["smrn"].ToString();

            string historytype = "SH";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            

            con.Open();
             SqlCommand cmd = new SqlCommand("delete from Medical_history where patient_id=" + val + " and history_type='SH'", con);
            cmd.ExecuteNonQuery();


            con.Close();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);
            cmd1.Parameters.AddWithValue("@code1", "MarSt");
            string yesorno = "";
            if (ChkMar.Checked)
            {
                yesorno = "Married";
            }
            else if (ChkSin.Checked)
            {
                yesorno = "Single";
            }
            cmd1.Parameters.AddWithValue("@value1", yesorno);
            cmd1.Parameters.AddWithValue("@note1", "no note");
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@history_type", historytype);

            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type)", con);


            cmd2.Parameters.AddWithValue("@patient_id2", val);
            cmd2.Parameters.AddWithValue("@code2", "Smok");

            if (chkSm.Checked)
            {
                yesorno = "Smoking";
                cmd2.Parameters.AddWithValue("@note2", txtYears.Text);
            }
            else if (chkNSm.Checked)
            {
                yesorno = "Non Smoking";
                cmd2.Parameters.AddWithValue("@note2","");
            }
            cmd2.Parameters.AddWithValue("@value2", yesorno);
            

            cmd2.Parameters.AddWithValue("@datestamp2", d);
            cmd2.Parameters.AddWithValue("@history_type", historytype);
            cmd2.ExecuteNonQuery();

           

            SqlCommand cmd4 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type)", con);

            cmd4.Parameters.AddWithValue("@patient_id4", val);
            cmd4.Parameters.AddWithValue("@code4", "Dru");

            if (chkDru.Checked)
            {
                yesorno = "Drugs";
            }
            else if (chkNDru.Checked)
            {
                yesorno = "No Drugs";
            }
            cmd4.Parameters.AddWithValue("@value4", yesorno);
            cmd4.Parameters.AddWithValue("@note4", "no note");

            cmd4.Parameters.AddWithValue("@datestamp4", d);
            cmd4.Parameters.AddWithValue("@history_type", historytype);

            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id5,@code5,@value5,@note5,@datestamp5,@history_type)", con);

            cmd5.Parameters.AddWithValue("@patient_id5", val);
            cmd5.Parameters.AddWithValue("@code5", "Alco");

            if (chkAlc.Checked)
            {
                yesorno = "Alcohol";
            }
            else if(chkNAlc.Checked)
            {
                yesorno = "Non Alcohol";
            }
            cmd5.Parameters.AddWithValue("@value5", yesorno);
            cmd5.Parameters.AddWithValue("@note5",txtAlFreq.Text);

            cmd5.Parameters.AddWithValue("@datestamp5", d);
            cmd5.Parameters.AddWithValue("@history_type", historytype);

            cmd5.ExecuteNonQuery();
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