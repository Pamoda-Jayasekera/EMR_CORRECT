using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSENMT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtENMT.Text = "ENMT: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + " Ear- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Difficulty hearing|";
            }
            if (CheckBox2.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Ear pain|";
            }

            if (CheckBox5.Checked == true || CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true)
           
            {
                txtENMT.Text = txtENMT.Text + " Nose- ";
            }
            if (CheckBox5.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Frequent nose bleeding|";
            }
            if (CheckBox6.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Stuffy nose|";
            }
            if (CheckBox7.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Sinu problem|";
            }
            if (CheckBox8.Checked == true)
            {
                txtENMT.Text = txtENMT.Text + "Other|";
            }

            if (CheckBox3.Checked == true || CheckBox4.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true)
            {

                txtENMT.Text = txtENMT.Text + " Mouth/Throat- ";
            }   
                if (CheckBox3.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Sore throat|";
                }
                if (CheckBox4.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Bleeding gums|";
                }
                if (CheckBox9.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Dry mouth|";
                }
                if (CheckBox10.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Snoring|";
                }
                if (CheckBox11.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Oral abnomalities|";
                }
                if (CheckBox12.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Mouth ulcers|";
                }
                if (CheckBox13.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Teeth abnomlities|";
                }
                if (CheckBox14.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Mouth bleeding|";
                }
                if (CheckBox15.Checked == true)
                {
                    txtENMT.Text = txtENMT.Text + "Other|";
                }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "ENMT";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtENMT.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtENMT.Text = "";
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