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
        }
    }
}