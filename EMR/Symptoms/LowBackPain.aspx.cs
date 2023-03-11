using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class LowBackPain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "LOW BACK PAIN: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Pain- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Began Suddenly | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gradually worsens over time | ";
            }
            if (CheckBox3.Checked == true || CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Trigged by- ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Everyday activities | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Injury | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Overuse | ";
            }

            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Relieved by-Bending over or leaning for something for support | ";
            }
            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Worsened by- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Movement | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Prolonged sitting or standing | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Prolonged rest or inactivity | ";
            }
            if (CheckBox10.Checked == true || CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in bowl or bladder function | ";
            }

            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Knot or tight spot in black muscle | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Leg or foot pain | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stiffness in lower back | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Swelling | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "weakness, numbness or tingling in leg or foot | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Low Back Pain";

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