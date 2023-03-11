using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class AbdominalPain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

      

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "ABDOMINAL PAIN: ";
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Began Suddenly | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Intermittent or episodic | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Burning | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Ongoing(chronic) | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Crampy | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sharp | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gnawing | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Steady | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Intense | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Worsening or progressing | ";
            }
            if(CheckBox11.Checked==true || CheckBox12.Checked == true || CheckBox13.Checked ==true || CheckBox14.Checked == true || CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Located in- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Abdomen but radiates to other parts of the body | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Lower abdomen | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Middle abdomen | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "One or both sides | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Upper abdomen | ";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Triggered or Worsened By- ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Coughing or other jarring movements | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Drinking Alcohol | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Eating certain foods | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Menstrual Cycle | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cycle Stress | ";
            }
            if (CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Relieved By- ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Antacids | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Avoiding certain foods | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Changing position | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Drinking more water | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Eating certain foods | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Eating more fiber | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Accompanied By-Abdominal Swelling | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Abdominal Pain";
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);
            
                cmd1.Parameters.AddWithValue("@patient_id1",mrn);
                cmd1.Parameters.AddWithValue("@app_code1",apc );
                cmd1.Parameters.AddWithValue("@symptom1", symp);
                string des = txtAbdom.Text;
                cmd1.Parameters.AddWithValue("@note1",des);
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