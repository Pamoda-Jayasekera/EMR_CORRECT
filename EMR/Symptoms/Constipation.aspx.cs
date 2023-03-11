using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class Constipation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtCons.Text = "CONSTIPATION: ";
            if (CheckBox1.Checked == true || CheckBox3.Checked == true || CheckBox5.Checked == true)
            {
                txtCons.Text = txtCons.Text + " Problem is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtCons.Text = txtCons.Text + "On going or recurrent | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Recent | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Worsening or progressing | ";
            }
            if (CheckBox2.Checked == true || CheckBox4.Checked == true || CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true || CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true || CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true)
            {
                txtCons.Text = txtCons.Text + " Accompanied By- ";
            }
            if (CheckBox2.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Abdominal Pain | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Anal or rectal pain | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Bloody stools | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Change in bowel habits that lasts longer than four weeks | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Constipation | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Cramping | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Diarrhea | ";
            }
            if (CheckBox11.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Fatigue or weakness | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Fever | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Gas | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Increased sensitivity to cold | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Mucus in stools | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Muscle or joint aches | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Muscle weakness | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Narrow stools | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Nausea or vomiting | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Painful bowel movements | ";
            }
            if (CheckBox21.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Pale,dry skin | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Persistent abdominal discomfort, such as cramps, gas or pain | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Unexplained fatigue | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Unintended weight gain | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Unintended weight loss | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Constipation";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@app_code1", apc);
            cmd1.Parameters.AddWithValue("@symptom1", symp);
            string des = txtCons.Text;
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