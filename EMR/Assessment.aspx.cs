using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class Assessment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtAss.Focus();
            if (!IsPostBack == true)
            {
                GridView1.DataSource = SqlDataSource3;
                GridView1.DataBind();
                // Define userType here
                string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

                // Disable controls if logged in as a patient
                if (userType == "PT")
                {
                    DisableControls(this);
                }
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

        protected void txtAss_TextChanged(object sender, EventArgs e)
        {
            if (txtAss.Text == "DEL")
            {
                string val = Session["smrn"].ToString();
                String mycon = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                String updatedata = "delete from Assessment where datestamp='" + DateTime.Now + "'and patient_id="+val;
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                GridView1.DataSource = SqlDataSource3;
                GridView1.DataBind();
                txtAss.Text = "";
            }

            if (txtAss.Text.Length > 4)
            {
                string rbtxt = txtAss.Text;
                string key = txtAss.Text.Substring(0, 4);
                string des = rbtxt.Substring(4);
                if (key == "FIN ")
                {
                    txtFin.Text = des;
                    txtAss.Text = "";
                }
                if (key == "PLA ")
                {
                    txtPla.Text = des;
                    txtAss.Text = "";
                }
            }
            if (txtAss.Text == "HOM")
            {
                txtAss.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            if (txtAss.Text == "ADD")
            {
                btnSubmit_Click(sender, e);
                txtAss.Text = "";
                txtFin.Text = "";
                txtPla.Text = "";
            }

            string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

            if (userType == "PT")
            {
                if (txtAss.Text != "HOM")
                {
                    // If user is PT and text is not HOM, reset the TextBox and do nothing
                    txtAss.Text = "";
                    return;
                }

                // Handle navigation for PT user if text is HOM
                Response.Redirect("PatientDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }

        }
       
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string val = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string d = DateTime.Now.ToString();
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("Insert into Assessment" + "(ap_code,patient_id,findings,plans,datestamp)values(@ap_code1,@patient_id1,@findings1,@plans1,@datestamp1)", con);
                    cmd1.Parameters.AddWithValue("@ap_code1", apc);
                    cmd1.Parameters.AddWithValue("@patient_id1", val);
                    cmd1.Parameters.AddWithValue("@findings1",txtFin.Text);
                    cmd1.Parameters.AddWithValue("@plans1", txtPla.Text);
                    cmd1.Parameters.AddWithValue("@datestamp1", d);
                    cmd1.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource3;
            GridView1.DataBind();
            con.Close();

        }

       
    }
}
    
