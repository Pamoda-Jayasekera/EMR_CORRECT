using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class ReviewofSystem : System.Web.UI.Page
    {
        public object Repeater1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack == true)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();

            }

        }
        
        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            else if (txtHOM.Text == "General")
            {
                Response.Redirect("ROSAll.aspx");
            }
            else if (txtHOM.Text == "Constitutional")
            {
                Response.Redirect("RoSConstitutional.aspx");
            }
            else if(txtHOM.Text == "Eyes")
            {
                Response.Redirect("RoSEyes.aspx");
            }
            else if (txtHOM.Text == "ENMT")
            {
                Response.Redirect("RoSENMT.aspx");
            }
            else if (txtHOM.Text == "Cardiovascular")
            {
                Response.Redirect("RoSCardiovascular.aspx");
            }
            else if (txtHOM.Text == "Respiratory")
            {
                Response.Redirect("RoSRespiratory.aspx");
            }
            else if (txtHOM.Text == "Gastrointestinal")
            {
                Response.Redirect("RoSGastrointestinal.aspx");
            }
            else if (txtHOM.Text == "Genitourinary")
            {
                Response.Redirect("RoSGenitourinary.aspx");
            }
            else if (txtHOM.Text == "Musculoskeletal")
            {
                Response.Redirect("RoSMusculoskeletal.aspx");
            }
            else if (txtHOM.Text == "Neurologic")
            {
                Response.Redirect("RoSNeurologic.aspx");
            }
            else if (txtHOM.Text == "Psychiatric")
            {
                Response.Redirect("RoSPsychiatric.aspx");
            }
            else if (txtHOM.Text == "Endocrine")
            {
                Response.Redirect("RoSEndocrine.aspx");
            }
            else if (txtHOM.Text == "Hematologic" || txtHOM.Text== "Lymphatic")
            {
                Response.Redirect("RoSHematologic.aspx");
            }
            else if(txtHOM.Text== "Allergic" || txtHOM.Text== "Immunologic")
            {
                Response.Redirect("RoSAllergic.aspx");
            }
            
        }
    }
}