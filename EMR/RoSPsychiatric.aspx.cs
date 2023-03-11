using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSPsychiatric : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtPsy.Text = "PSYCHIATRIC: ";
            if (CheckBox1.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + " Depression | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + "  Alcohol Abuse | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + "  Sleep Disturbances | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + "  Restless Sleep | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + "  Anxiety | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtPsy.Text = txtPsy.Text + "  Phobias | ";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Psychiatric";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtPsy.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtPsy.Text = "";
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("ReviewofSystem.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}