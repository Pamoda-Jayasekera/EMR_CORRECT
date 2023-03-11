using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace EMR
{
    public partial class PresentIllness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            LoadSymptoms();
        }
        protected void LoadSymptoms()
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmdn = new SqlCommand("select * from PresentIllness where patient_id=" + mrn + " and app_code=" +apc, con);

            SqlDataAdapter sda = new SqlDataAdapter("select * from PresentIllness where patient_id=" + mrn + " and app_code=" + apc, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataReader rn = cmdn.ExecuteReader();
            if (rn.HasRows)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    txtSymptoms.Text += dt.Rows[i].ItemArray[3].ToString() + "\n";

                }
                dt.Clear();
            }
            if (!rn.HasRows)
            {

            }
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from PresentIllness where patient_id=" + mrn + " and app_code=" + apc, con);

            int yeartoday = DateTime.Now.Year;
            cmd.ExecuteNonQuery();
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r.GetValue(2).ToString() == "Abdominal Pain")
                    {
                        CheckBox1.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Black or Bloody Stools")
                    {
                        CheckBox2.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Chest Pain")
                    {
                        CheckBox3.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Constipation")
                    {
                        CheckBox4.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Cough")
                    {
                        CheckBox5.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Diarrhea")
                    {
                        CheckBox6.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Difficulty Swallowing")
                    {
                        CheckBox7.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Dizziness")
                    {
                        CheckBox8.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Eye Discomfort and Redness")
                    {
                        CheckBox9.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Foot Pain or Ankle Pain")
                    {
                        CheckBox10.Checked = true;


                    }
                    
                    if (r.GetValue(2).ToString() == "Foot Swelling or Leg Swelling")
                    {
                        CheckBox11.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Headache")
                    {
                        CheckBox12.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Heart Palpitations")
                    {
                        CheckBox13.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Hip Pain")
                    {
                        CheckBox14.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Knee Pain")
                    {
                        CheckBox15.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Low Back Pain")
                    {
                        CheckBox16.Checked = true;
                    }
                    if (r.GetValue(2).ToString() == "Nasal Congestion")
                    {
                        CheckBox17.Checked = true;
                    }
                    if (r.GetValue(2).ToString() == "Nausea or Vomitting")
                    {
                        CheckBox18.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Neck Pain")
                    {
                        CheckBox19.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Numbness or Tingling in Hands")
                    {
                        CheckBox20.Checked = true;
                    }
                    if (r.GetValue(2).ToString() == "Pelvic Pain:Female")
                    {
                        CheckBox21.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Pelvic Pain:Male")
                    {
                        CheckBox22.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Shortness of Breath")
                    {
                        CheckBox23.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Shoulder Pain")
                    {
                        CheckBox24.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Sore Throat")
                    {
                        CheckBox25.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Urinary Problem")
                    {
                        CheckBox26.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Vision Problem")
                    {
                        CheckBox27.Checked = true;


                    }
                    if (r.GetValue(2).ToString() == "Wheezing")
                    {
                        CheckBox28.Checked = true;


                    }
                }
            }
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