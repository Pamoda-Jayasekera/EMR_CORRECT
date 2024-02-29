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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string val = Session["smrn"].ToString();
            string userType = Session["hom"].ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] WHERE patient_id=@patient_id", con);
                cmd.Parameters.AddWithValue("@patient_id", val);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }

            txtHOM.Focus();

            if (!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now;
                txtDate.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
            }

            if (!IsPostBack)
            {
                // Set all the controls to readonly or disabled, as needed
                // Only if the user is a PT (patient)
                if (userType == "PT")
                {
                    DisableControls(this);


                    // Except for txtHOM, which is allowed to use the keyword "HOM"
                    txtHOM.Attributes["readonly"] = "readonly"; // Make it readonly by default
                    txtHOM.Attributes.Remove("readonly"); // Remove readonly when page is not a postback, allows entering "HOM"
                    txtHOM.Focus();
                }
                Calendar1.SelectedDate = DateTime.Now;
                txtDate.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
            }
        }


        //new code 

        private void DisableControls(Control parent)
        {
            // Get the user type from the "hom" session variable
            string userType = Session["hom"].ToString();
            if (userType == "PT") // Check if the user is a PT before disabling controls
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is TextBox && c.ID != "txtHOM") // Exclude txtHOM
                    {
                        ((TextBox)c).Attributes["readonly"] = "readonly";
                    }
                    else if (c is Button)
                    {
                        ((Button)c).Enabled = false;
                    }
                    else if (c is DropDownList)
                    {
                        ((DropDownList)c).Enabled = false;
                    }
                    // ... include other control types as needed

                    if (c.HasControls())
                    {
                        DisableControls(c); // Only disable child controls if user is PT
                    }
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string val = Session["smrn"].ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("INSERT INTO [Order] (patient_id, type, description, dosage, datestamp) VALUES (@patient_id, @type, @description, @dosage, @datestamp)", con);

            cmd1.Parameters.AddWithValue("@patient_id", val);
            cmd1.Parameters.AddWithValue("@type", "Med");
            cmd1.Parameters.AddWithValue("@description", txtHOM.Text);
            cmd1.Parameters.AddWithValue("@dosage", txtDosage.Text);
            cmd1.Parameters.AddWithValue("@datestamp", txtDate.Text);

            try
            {
                con.Open();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }

            GridView1.DataBind();
            txtHOM.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            string val = Session["smrn"].ToString();
            Label des = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
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
            // New condition for when prev is "PT"
            if (txtHOM.Text == "HOM" && prev == "PT")
            {
                txtHOM.Text = "";
                Response.Redirect("PatientDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }

        }




    }
}