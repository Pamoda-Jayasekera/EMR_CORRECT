using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class FollowUps : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
                txtRBox.Focus();
                txtDate.Text = DateTime.Now.ToString("M/dd/yyyy");

                if (Session["smrn"] != null)
                {
                    string val = Session["smrn"].ToString();
                    TextBox2.Text = val;
                }
                if (Session["sname"] != null)
                {
                    string val1 = Session["sname"].ToString();
                    TextBox1.Text = val1;
                }

                string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty; // Declare userType
                if (userType == "PT")
                {
                    DisableControls(this);
                }
            }
        

        private void DisableControls(Control parent)
        {
            string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

            if (userType == "PT") // Check if the user is a PT before disabling controls
            {
                foreach (Control c in parent.Controls)
                {
                    // Check for TextBox and exclude txtHOM
                    if (c is TextBox textBox && c.ID != "txtHOM")
                    {
                        textBox.Attributes["readonly"] = "readonly";
                    }
                    // Check and disable Button controls
                    else if (c is Button button)
                    {
                        button.Enabled = false;
                    }
                    // Check and disable CheckBox controls
                    else if (c is CheckBox checkBox)
                    {
                        checkBox.Enabled = false;
                    }
                    // Check and disable DropDownList controls
                    else if (c is DropDownList dropDownList)
                    {
                        dropDownList.Enabled = false;
                    }
                    // ... include other control types as needed

                    // Recursively disable child controls if user is PT
                    if (c.HasControls())
                    {
                        DisableControls(c);
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Follow_Up (patient_name,patient_id,app_call,foll_date,foll_phys,foll_ma,foll_spec,foll_physio,foll_diet,sub_lab,datestamp)values(@patient_name,@patient_id,@app_call,@foll_date,@foll_phys,@foll_ma,@foll_spec,@foll_physio,@foll_diet,@sub_lab,@datestamp)", con);
            cmd1.Parameters.AddWithValue("@patient_name", TextBox1.Text);
            cmd1.Parameters.AddWithValue("@patient_id", TextBox2.Text);
            cmd1.Parameters.AddWithValue("@app_call", TextBox3.Text);
            cmd1.Parameters.AddWithValue("@foll_date", TextBox4.Text);
            cmd1.Parameters.AddWithValue("@foll_phys", TextBox5.Text);
            cmd1.Parameters.AddWithValue("@foll_ma", TextBox6.Text);
            cmd1.Parameters.AddWithValue("@foll_spec", TextBox7.Text);
            cmd1.Parameters.AddWithValue("@foll_physio", TextBox8.Text);
            cmd1.Parameters.AddWithValue("@foll_diet", TextBox9.Text);
            cmd1.Parameters.AddWithValue("@sub_lab", TextBox10.Text);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp", d);
            cmd1.ExecuteNonQuery();     
            con.Close();
        }

        protected void txtRBox_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtRBox.Text == "HOM")
                {
                    txtRBox.Text = "";
                    Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
                }

                string prev = Session["hom"] != null ? Session["hom"].ToString() : string.Empty; // Declare prev
                if (txtRBox.Text == "HOM" && prev == "PT")
                {
                    txtRBox.Text = "";
                    Response.Redirect("PatientDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
                }
            }
        }
    }
}