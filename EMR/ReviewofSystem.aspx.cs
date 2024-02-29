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
            // Define userType here
            string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

            // Disable controls if logged in as a patient
            if (userType == "PT")
            {
                DisableControls(this);
            }
        }
    

    //NEW CODE 
    //new code 
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