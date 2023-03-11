using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class UrinaryProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "URINARY PROBLEM: ";
            if (CheckBox31.Checked == true || CheckBox2.Checked == true || CheckBox4.Checked == true || CheckBox16.Checked == true || CheckBox32.Checked == true || CheckBox33.Checked == true
             || CheckBox1.Checked == true || CheckBox34.Checked == true | CheckBox13.Checked == true | CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Urinary problem is- ";
            }
            if (CheckBox31.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blood in urine | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in urine color | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cloudy urine | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Frequent urination | ";
            }
            if (CheckBox32.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Involuntary loss of urine | ";
            }
            if (CheckBox33.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pain or burning when urinating | ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Awaking two or more times in the night to urinate | ";
            }
            if (CheckBox34.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Strong, persistent urge to urinate | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficulty emptying bladder or weak urine stream | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficulty starting urination | ";
            }
            if (CheckBox11.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true || CheckBox3.Checked == true || CheckBox35.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Related pain involves- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Itching or burning around genitals, buttocks or inner thighs | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pain in back or side | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pain in lower abdomen or groin | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Painful ejaculation | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Painful sexual intercourse | ";
            }
            if (CheckBox36.Checked == true || CheckBox37.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Worsened by- ";
            }
            if (CheckBox36.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Menstrual cycle | ";
            }
            if (CheckBox37.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stress | ";
            }
            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox15.Checked == true || CheckBox19.Checked == true || CheckBox10.Checked == true
           || CheckBox18.Checked == true || CheckBox12.Checked == true || CheckBox17.Checked == true || CheckBox21.Checked == true || CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blurred vision | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bumps, blisters or open sores around genitals | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in vaginal discharge | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Extreme thirst or hunger | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fatigue | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Clear discharge from penis | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pus-filled discharge from penis | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }

            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Nausea or vomiting | ";
            }

            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Vaginal odor | ";
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
            string symp = "Urinary Problem";

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