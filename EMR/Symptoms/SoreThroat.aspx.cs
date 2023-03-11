using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class SoreThroat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "SORE THROAT: ";
            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox15.Checked == true || CheckBox19.Checked == true || CheckBox12.Checked == true
            || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox20.Checked == true || CheckBox21.Checked == true
            || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blue-colored skin or lips | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Chills or sweating | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cough | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficult or painful swallowing | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficult or raspy breathing | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Enlarged, tender lymph nodes in neck | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Headache or facial pain | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Heartburn | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Hoarse or muffled voice | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Muscle aches | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Red, swollen tonsils | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Runny or stuffy nose | ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Skin rash | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sneezing | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Watery eyes | ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "White patches or pus on tonsils | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Yellow or greenish phlegm or discharge from your nose | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Sore Throat";

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