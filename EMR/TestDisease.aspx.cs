using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace EMR
{
    public partial class TestDisease : System.Web.UI.Page
    {
        private readonly string connectionString = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtHOM.Focus();
                LoadTESTHistory();
            }
        }

        protected void LoadTESTHistory()
        {
            if (Session["smrn"] != null)
            {
                string patientId = Session["smrn"].ToString();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT code, value, note FROM DiagnosisData WHERE patient_id=@patientId AND history_type='FRD'", con);
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
                                case "BloodTest":
                                    BloodTesty.Checked = (value == "Blood Test Yes");
                                    BloodTestn.Checked = (value == "Blood Test No");
                                    break;
                                case "UrineTest":
                                    UrineTesty.Checked = (value == "Urine Test Yes");
                                    UrineTestn.Checked = (value == "Urine Test No");
                                    break;
                                case "Ultrasound":
                                    Ultrasoundy.Checked = (value == "Ultrasound Yes");
                                    Ultrasoundn.Checked = (value == "Ultrasound No");
                                    break;
                                case "CTScan":
                                    CTScany.Checked = (value == "CT Scan Yes");
                                    CTScann.Checked = (value == "CT Scan No");
                                    break;
                                case "MRI":
                                    MRIy.Checked = (value == "MRI Yes");
                                    MRIn.Checked = (value == "MRI No");
                                    break;
                                case "ECG":
                                    ECGy.Checked = (value == "ECG Yes");
                                    ECGn.Checked = (value == "ECG No");
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

            string historytype = "FRD";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");


            con.Open();
            SqlCommand cmd = new SqlCommand("delete from DiagnosisData where patient_id=" + val + " and history_type='FRD'", con);
            cmd.ExecuteNonQuery();


            con.Close();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);
            cmd1.Parameters.AddWithValue("@code1", "Dose1");
            string yesorno = "";
            if (BloodTesty.Checked)
            {
                yesorno = "Blood Test Yes";
            }
            else if (BloodTestn.Checked)
            {
                yesorno = "Blood Test No";
            }
            cmd1.Parameters.AddWithValue("@value1", yesorno);
            cmd1.Parameters.AddWithValue("@note1", "");
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@history_type", historytype);

            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type)", con);


            cmd2.Parameters.AddWithValue("@patient_id2", val);
            cmd2.Parameters.AddWithValue("@code2", "Dose2");

            if (UrineTesty.Checked)
            {
                yesorno = "Urine Test Yes";
                cmd2.Parameters.AddWithValue("@note2", "");
            }
            else if (UrineTestn.Checked)
            {
                yesorno = "Urine Test No";
                cmd2.Parameters.AddWithValue("@note2", "");
            }
            cmd2.Parameters.AddWithValue("@value2", yesorno);


            cmd2.Parameters.AddWithValue("@datestamp2", d);
            cmd2.Parameters.AddWithValue("@history_type", historytype);
            cmd2.ExecuteNonQuery();



            SqlCommand cmd4 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type)", con);

            cmd4.Parameters.AddWithValue("@patient_id4", val);
            cmd4.Parameters.AddWithValue("@code4", "Dose3");

            if (Ultrasoundy.Checked)
            {
                yesorno = "Ultrasound Yes";
            }
            else if (Ultrasoundn.Checked)
            {
                yesorno = "Ultrasound No";
            }
            cmd4.Parameters.AddWithValue("@value4", yesorno);
            cmd4.Parameters.AddWithValue("@note4", "");

            cmd4.Parameters.AddWithValue("@datestamp4", d);
            cmd4.Parameters.AddWithValue("@history_type", historytype);

            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id5,@code5,@value5,@note5,@datestamp5,@history_type)", con);

            cmd5.Parameters.AddWithValue("@patient_id5", val);
            cmd5.Parameters.AddWithValue("@code5", "Dose4");

            if (CTScany.Checked)
            {
                yesorno = "CT Scan Yes";
            }
            else if (CTScann.Checked)
            {
                yesorno = "CT Scan No";
            }
            cmd5.Parameters.AddWithValue("@value5", yesorno);
            cmd5.Parameters.AddWithValue("@note5", "");

            cmd5.Parameters.AddWithValue("@datestamp5", d);
            cmd5.Parameters.AddWithValue("@history_type", historytype);

            cmd4.ExecuteNonQuery();


            SqlCommand cmd6 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id6,@code6,@value6,@note6,@datestamp6,@history_type)", con);

            cmd6.Parameters.AddWithValue("@patient_id6", val);
            cmd6.Parameters.AddWithValue("@code6", "Dose5");

            if (MRIy.Checked)
            {
                yesorno = "MRI Yes";
            }
            else if (MRIn.Checked)
            {
                yesorno = "MRI No";
            }
            cmd6.Parameters.AddWithValue("@value6", yesorno);
            cmd6.Parameters.AddWithValue("@note6", "");

            cmd6.Parameters.AddWithValue("@datestamp6", d);
            cmd6.Parameters.AddWithValue("@history_type", historytype);

            cmd6.ExecuteNonQuery();


            SqlCommand cmd7 = new SqlCommand("Insert into DiagnosisData" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id7,@code7,@value7,@note7,@datestamp7,@history_type)", con);

            cmd7.Parameters.AddWithValue("@patient_id7", val);
            cmd7.Parameters.AddWithValue("@code7", "Dose6");

            if (ECGy.Checked)
            {
                yesorno = "ECG Yes";
            }
            else if (ECGn.Checked)
            {
                yesorno = "ECG No";
            }
            cmd7.Parameters.AddWithValue("@value7", yesorno);
            cmd7.Parameters.AddWithValue("@note7", "");

            cmd7.Parameters.AddWithValue("@datestamp7", d);
            cmd7.Parameters.AddWithValue("@history_type", historytype);

            cmd7.ExecuteNonQuery();

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