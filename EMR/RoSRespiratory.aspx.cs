using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSRespiratory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtResp.Text = "RESPIRATORY: ";
            if (CheckBox1.Checked == true)
            {
                txtResp.Text = txtResp.Text + "Cough | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtResp.Text = txtResp.Text + " Wheezing | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtResp.Text = txtResp.Text + " Cough Up Blood | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtResp.Text = txtResp.Text + " Shorteness Of Breath | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtResp.Text = txtResp.Text + " Sleep Apnea | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtResp.Text = txtResp.Text + " Snoring | ";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Respiratory";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtResp.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtResp.Text = "";
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