using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class ChestPain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtChestPain.Text = "CHEST PAIN: ";
            if (CheckBox1.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Achy or gnawing | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Burning | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Severe | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Sharp | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Squeezing or pressure | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Sudden | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Tight | ";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + " Problem is- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "New or recent | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Ongoing or recurrent | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Preceded by upper respiratory illness,";
            }
            if (CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + " Relieved By- ";
            }
            if (CheckBox21.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Antacids | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Bending forward | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Rent | ";
            }
            if (CheckBox16.Checked == true || CheckBox8.Checked == true || CheckBox17.Checked == true || CheckBox9.Checked == true || CheckBox18.Checked == true || CheckBox10.Checked == true || CheckBox19.Checked == true || CheckBox14.Checked == true || CheckBox20.Checked == true || CheckBox15.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + " Triggered or worsened By- ";
            }
            if (CheckBox16.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Allergens or Irritants | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Mild to moderate exertion | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Eating or drinking | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Pressing on chest wall | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Exertion | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Smoking | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Exposure to cold air | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Stress | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Lying down for a long period | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Taking a deep breath | ";
            }
            if (CheckBox27.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox28.Checked == true || CheckBox29.Checked == true || CheckBox30.Checked == true || CheckBox31.Checked == true || CheckBox32.Checked == true || CheckBox33.Checked == true || CheckBox34.Checked == true || CheckBox35.Checked == true || CheckBox36.Checked == true || CheckBox37.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + " Accompanied By- ";
            }
            if (CheckBox27.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Anxiety | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Belching | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Cough with blood or phlegm | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Difficult or painful swallowing | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Dry cough | ";
            }
            if (CheckBox29.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Fainting or dizziness | ";
            }
            if (CheckBox30.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Fever | ";
            }
            if (CheckBox31.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Headache | ";
            }
            if (CheckBox32.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Nausea or vomiting | ";
            }
            if (CheckBox33.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Pain in neck,jaw,arms,shoulders or back | ";
            }
            if (CheckBox34.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Rapid or irregular heartbeat | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Shortness of breath | ";
            }
            if (CheckBox36.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Sweating | ";
            }
            if (CheckBox37.Checked == true)
            {
                txtChestPain.Text = txtChestPain.Text + "Unexplained fatigue | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Chest Pain";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@app_code1", apc);
            cmd1.Parameters.AddWithValue("@symptom1", symp);
            string des = txtChestPain.Text;
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