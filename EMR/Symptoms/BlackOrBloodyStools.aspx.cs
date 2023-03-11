using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class BlackOrBloodyStools : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtBloSt.Text = "BLACK OR BLOODY STOOLS: ";
            if (CheckBox1.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Constipation | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Diarrhea | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Fever | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Inability to move bowels in spite of urge | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Loose,watery stools | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Nausea or vomiting | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Passing gas | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Pulsing sensation near the navel | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Rash | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Stomach growling or grumbling | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Unintended weight loss | ";
            }
            if (CheckBox29.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Urgent need to have a bowel movement | ";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + " Blood appears- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "In or on the stool | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "In toilet bowl or on toilet tissue | ";
            }
            if (CheckBox15.Checked == true || CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + " Triggered or Worsened By- ";
            }
            if (CheckBox15.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Drinking alcohol or caffeine | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Eating certain foods | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Straining during bowel movements | ";
            }
            if (CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + " Relieved By- ";
            }
            if (CheckBox21.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Drinking more water | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Eating certain foods | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Eating more fiber | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Eating certain foods | ";
            }

            if (CheckBox27.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox30.Checked == true || CheckBox31.Checked == true || CheckBox32.Checked == true || CheckBox33.Checked == true || CheckBox34.Checked == true || CheckBox35.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + " Accompanied By- ";
            }
            if (CheckBox27.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Abdominal pain or cramping | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Anal itching | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Change in bowel habits that lasts longer than four weeks | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Change in your bowel habits | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Constipation | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Diarrhea | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Fatigue or weakness | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Fever | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Frequent urge to have bowel movement | ";
            }
            if (CheckBox30.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Narrow stools | ";
            }
            if (CheckBox31.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Nausea or vomiting | ";
            }
            if (CheckBox32.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Painful bowel movements | ";
            }
            if (CheckBox33.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Persistent abdominal discomfort, such as cramps, gas or pain | ";
            }
            if (CheckBox34.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Rectal pain | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtBloSt.Text = txtBloSt.Text + "Unintended weight loss | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Black or Bloody Stools";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@app_code1", apc);
            cmd1.Parameters.AddWithValue("@symptom1", symp);
            string des = txtBloSt.Text;
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