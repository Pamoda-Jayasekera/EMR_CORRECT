using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class Swallowing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "DIFFICULTY SWALLOWING: ";
            if (CheckBox1.Checked == true || CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Swallowing- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Hurts | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Takes effort | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Trigged or worsened by-Eating certain foods | ";
            }
            if (CheckBox4.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true || CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bad breath | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cough | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficulty breathing | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dry mouth | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Earche | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Feeling of something stuck in your throat | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Heartburn | ";
            }

            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Hoarse voice or difficulty speaking | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Jaw pain or stiffness | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Loose teeth or poorly fitting dentures | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Lump in front of neck | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Mouth sores, lumps or pain | ";
            }

            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pain in chest or back | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Regurgitation of food or sour liquid | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sore throat | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Thick saliva | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Unintended weight loss | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Difficulty Swallowing";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@app_code1", apc);
            cmd1.Parameters.AddWithValue("@symptom1", symp);
            string des = txtAbdom.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.ExecuteNonQuery();
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "ADD")
            {
                btnSubmit_Click(sender, e);
                btnAdd_Click(sender, e);
            }

            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("~/PresentIllness.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}