using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class Vaccination : System.Web.UI.Page
    {
        private readonly string connectionString = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtHOM.Focus();
                LoadVaccineHistory();
            }
        }

        protected void LoadVaccineHistory()
        {
            if (Session["smrn"] != null)
            {
                string patientId = Session["smrn"].ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT code, value, note FROM Medical_history WHERE patient_id=@patientId AND history_type='VC'", con);
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
                                case "Dose1":
                                    Dose1y.Checked = (value == "Yes");
                                    Dose1n.Checked = (value == "No");
                                    break;
                                case "Dose2":
                                    Dose2y.Checked = (value == "Yes");
                                    Dose2n.Checked = (value == "No");
                                   
                                    break;
                                case "Dose3":
                                    Dose3y.Checked = (value == "Yes");
                                    Dose3n.Checked = (value == "No");
                                   
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

            string historytype = "VC";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");


            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Medical_history where patient_id=" + val + " and history_type='VC'", con);
            cmd.ExecuteNonQuery();


            con.Close();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);
            cmd1.Parameters.AddWithValue("@code1", "Dose1");
            string yesorno = "";
            if (Dose1y.Checked)
            {
                yesorno = "DOSE-1 Yes";
            }
            else if (Dose1n.Checked)
            {
                yesorno = "DOSE-1 No";
            }
            cmd1.Parameters.AddWithValue("@value1", yesorno);
            cmd1.Parameters.AddWithValue("@note1", "");
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@history_type", historytype);

            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type)", con);


            cmd2.Parameters.AddWithValue("@patient_id2", val);
            cmd2.Parameters.AddWithValue("@code2", "Dose2");

            if (Dose2y.Checked)
            {
                yesorno = "DOSE-2 Yes";
                cmd2.Parameters.AddWithValue("@note2", "");
            }
            else if (Dose2n.Checked)
            {
                yesorno = "DOSE-2 No";
                cmd2.Parameters.AddWithValue("@note2", "Dose 2");
            }
            cmd2.Parameters.AddWithValue("@value2", yesorno);


            cmd2.Parameters.AddWithValue("@datestamp2", d);
            cmd2.Parameters.AddWithValue("@history_type", historytype);
            cmd2.ExecuteNonQuery();



            SqlCommand cmd4 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type)", con);

            cmd4.Parameters.AddWithValue("@patient_id4", val);
            cmd4.Parameters.AddWithValue("@code4", "Dose3");

            if (Dose3y.Checked)
            {
                yesorno = "DOSE-3 Yes";
            }
            else if (Dose3n.Checked)
            {
                yesorno = "DOSE-3 No";
            }
            cmd4.Parameters.AddWithValue("@value4", yesorno);
            cmd4.Parameters.AddWithValue("@note4", "");

            cmd4.Parameters.AddWithValue("@datestamp4", d);
            cmd4.Parameters.AddWithValue("@history_type", historytype);

            cmd4.ExecuteNonQuery();

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