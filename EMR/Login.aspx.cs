using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace EMR
{
    public partial class Login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //user login

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM login_DB WHERE Username=@username AND password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (dr.GetValue(2).ToString() == "Doctor")
                    {
                        Session["category"] = "Doctor";
                        Response.Redirect("DoctorDashboard.aspx");
                    }
                    else if (dr.GetValue(2).ToString() == "Medical Assistant")
                    {
                        Session["category"] = "MA";
                        Response.Redirect("MADashboard.aspx");
                    }
                    else if (dr.GetValue(2).ToString() == "Clerk")
                    {
                        Session["category"] = "Clerk";
                        Response.Redirect("PatientRegistration.aspx");
                    }
                    //new code for the patient 
                    else if (dr.GetValue(2).ToString() == "Patient")
                    {
                        Session["category"] = "Patient";
                        Response.Redirect("PatientDashboard.aspx");
                    }
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUser.Text = "";

        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}