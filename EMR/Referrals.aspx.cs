using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EMR
{
    public partial class Referrals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            txtHOM.Focus();

            if (!IsPostBack == true)
            {
                GridView1.DataSource = SqlDataSource3;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            string val = Session["smrn"].ToString();
            Label des = GridView1.Rows[e.RowIndex].FindControl("Label2") as Label;
            String mycon = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            String updatedata = "delete from Referrals where patient_id=" + val + " AND doc_name='" + des.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource3;
            GridView1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            
            SqlCommand cmd2 = new SqlCommand("select [EMRdb].[dbo].[Specialization].description from [EMRdb].[dbo].[Specialization] inner join[EMRdb].[dbo].[Doctor] on[EMRdb].[dbo].[Specialization].speciality_code =[EMRdb].[dbo].[Doctor].[speciality_code] where Doctor.name = @key", con);
            cmd2.Parameters.Add(new SqlParameter("@key", txtHOM.Text));
            cmd2.ExecuteNonQuery();
            SqlDataReader r2 = cmd2.ExecuteReader();
            while (r2.Read())
            {
                txtName.Text = r2[0].ToString();
            }
            con.Close();
            con.Open();
            string val = Session["smrn"].ToString();
           
            SqlCommand cmd1 = new SqlCommand("Insert into Referrals" + "(patient_id,speciality,doc_name,datestamp)values(@patient_id1,@speciality,@doc_name,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);
            cmd1.Parameters.AddWithValue("@speciality", txtName.Text);
            cmd1.Parameters.AddWithValue("@doc_name", txtHOM.Text);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource3;
            GridView1.DataBind();
            txtHOM.Text = "";
            txtName.Text = "";
            con.Close();
        }

        protected void txtRef_TextChanged(object sender, EventArgs e)
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
            else
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}