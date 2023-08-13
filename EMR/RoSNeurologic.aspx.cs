using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSNeurologic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtNeu.Text = "NEUROLOGIC : ";
            if (CheckBox1.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Numbness | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Seizures | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Migrain | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Restrless legs | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Frequent Observe Headache | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Dizziness | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Loss Of Conciousness | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtNeu.Text = txtNeu.Text + " Weakness | ";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Neurologic";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtNeu.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtNeu.Text = "";
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            string prev = Session["hom"].ToString();
            if (txtHOM.Text == "HOM" && prev == "DOC")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            if (txtHOM.Text == "HOM" && prev == "MA")
            {
                txtHOM.Text = "";
                Response.Redirect("MADashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}