using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EMR
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack == true)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();

            }

            // Define userType here
            string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

            // Disable controls if logged in as a patient
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


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLab.Text != "")
            {
                string val = Session["smrn"].ToString();
                string d = DateTime.Now.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Insert into [Order]" + "(patient_id,type,description,dosage,datestamp)values(@patient_id1,@type1,@description1,@dosage1,@datestamp1)", con);

                cmd1.Parameters.AddWithValue("@patient_id1", val);

                cmd1.Parameters.AddWithValue("@type1", "Lab");
                cmd1.Parameters.AddWithValue("@description1", txtLab.Text);
                cmd1.Parameters.AddWithValue("@dosage1","null");
                cmd1.Parameters.AddWithValue("@datestamp1", d);
                cmd1.ExecuteNonQuery();
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
                txtLab.Text = "";
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            string val = Session["smrn"].ToString();
            Label des = GridView1.Rows[e.RowIndex].FindControl("Label2") as Label;
            String mycon = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            String updatedata = "delete from [Order] where patient_id=" + val + " AND description='" + des.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void txtOrd_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "Rx")
            {
                Response.Redirect("CurrentMedications.aspx");
                txtHOM.Text = "";
            }
            else if (txtHOM.Text == "Dx")
            {
                txtLab.Focus();
                txtHOM.Text = "";
            }
            else if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }

            string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

            if (userType == "PT")
            {
                if (txtHOM.Text != "HOM")
                {
                    // If user is PT and text is not HOM, reset the TextBox and do nothing
                    txtHOM.Text = "";
                    return;
                }

                // Handle navigation for PT user if text is HOM
                Response.Redirect("PatientDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }

        }
    }
}