using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class PelvicPainFemale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "PELVIC PAIN-FEMALE: ";
            if (CheckBox31.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Begin suddenly | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Ongoing | ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cyclical or recurrent | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sharp or crampy | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Different from usual menstrual cramps | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dull or achy | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Itching or burning around genitals, buttocks or inner thighs | ";
            }

            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox15.Checked == true
           || CheckBox18.Checked == true || CheckBox12.Checked == true || CheckBox19.Checked == true || CheckBox10.Checked == true
            || CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox20.Checked == true || CheckBox17.Checked == true
             || CheckBox25.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox27.Checked == true
              || CheckBox30.Checked == true || CheckBox29.Checked == true || CheckBox28.Checked == true || CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Abnormal vaginal bleeding | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Black or bloody stools | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bloating, constipation or diarrhea | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in vaginal discharge | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Increased waist size | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Excessive menstrual bleeding | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bumps, blisters or open sores | ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Lightheadedness or fainting | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Low back pain | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Irregular periods | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Frequent urination or urge to urinat | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Painful bowel movements | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Mood swings | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Nausea or vomiting | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Painful sexual intercourse | ";
            }
            if (CheckBox30.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Weight gain | ";
            }
            if (CheckBox29.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Unintended weight loss | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Skin rash | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Painful or difficult urination | ";
            }

            if (CheckBox11.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true || CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Worsened by- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Lifting or straining | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Pelvic Pain-Female";

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