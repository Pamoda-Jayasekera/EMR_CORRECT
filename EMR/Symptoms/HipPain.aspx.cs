using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class HipPain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "HIP PAIN: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Pain is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dull or achy | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sudden or intense | ";
            }
            if (CheckBox3.Checked == true || CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Decreased range of motion | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Locking or catching | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stiffness | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Swelling | ";
            }
            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Trigged or worsened by- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Activity or overuse | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Applying pressure or trying to bear weight | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Injury | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Long periods of rest | ";
            }

            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Movement | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Hip Pain";

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