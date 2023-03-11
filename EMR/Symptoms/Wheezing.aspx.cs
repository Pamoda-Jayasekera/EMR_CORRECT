using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class Wheezing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "WHEEZING: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Wheezing is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "New or recent | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Ongoing or recurrent | ";
            }


            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Preceded by- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Upper respiratory illness | ";
            }

            if (CheckBox4.Checked == true || CheckBox5.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Triggered or worsened by- ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Allergens or irritants | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Exposure to cold air | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Mild to moderate exertion | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Smoking,";
            }


            if (CheckBox3.Checked == true || CheckBox6.Checked == true || CheckBox35.Checked == true || CheckBox36.Checked == true || CheckBox16.Checked == true || CheckBox20.Checked == true
            || CheckBox21.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blue-colored skin or lips | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Chest pain or tightness | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Cough that produces sputum | ";
            }
            if (CheckBox36.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficult or painful swallowing | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dry cough | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fatigue or weakness | ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Hoarse or muffled voice | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Shortness of breath | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sore throat | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Wheezing";

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