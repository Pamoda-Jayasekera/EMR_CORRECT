using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class MALabReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack)
            {
                LoadImages(); // Call LoadImages method to bind data grid on initial load

                // Define userType here
                string userType = Session["hom"] != null ? Session["hom"].ToString() : string.Empty;

                // Disable controls if logged in as a patient
                if (userType == "PT")
                {
                    DisableControls(this);
                }
            }
        }

        //NEW CODE 

        private void LoadImages()
        {
            if (Session["smrn"] != null)
            {
                string patientId = Session["smrn"].ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT patient_id, image_name, image, CONVERT(nvarchar(10), datestamp, 120) AS datestamp FROM Images WHERE patient_id = @patientId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@patientId", patientId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    gvImages.DataSource = dt;
                    gvImages.DataBind();
                }
            }
        }
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
       /* protected void loadImages()
          {
              string val = Session["smrn"].ToString();
              string conn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
              using (SqlConnection con = new SqlConnection(conn))
              {
                  SqlCommand cmd = new SqlCommand("select patient_id,image_name,image,convert(nvarchar(10), datestamp, 120) as datestamp from Images where patient_id=" + val, con);
                  con.Open();
                  SqlDataReader rdr = cmd.ExecuteReader();
                  gvImages.DataSource = rdr;
                  gvImages.DataBind();
              }
          } */
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileuploadImage.HasFile)
            {
                string val = Session["smrn"].ToString();
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
                //getting length of uploaded file
                int length = fileuploadImage.PostedFile.ContentLength;
                //create a byte array to store the binary image data
                byte[] imgbyte = new byte[length];
                //store the currently selected file in memeory
                HttpPostedFile img = fileuploadImage.PostedFile;
                //set the binary data
                img.InputStream.Read(imgbyte, 0, length);
                //string imagename = txtImageName.Text;
                //use the web.config to store the connection string

                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Images(patient_id,image_name,image,datestamp) VALUES (@patient_id,@image_name,@image,@datestamp)", connection);
                //cmd.Parameters.Add("@imagename", SqlDbType.VarChar, 50).Value = imagename;
                cmd.Parameters.Add("@image", SqlDbType.Image).Value = imgbyte;
                cmd.Parameters.AddWithValue("@patient_id", val);
                cmd.Parameters.AddWithValue("@image_name", txtHOM.Text);
                string d = DateTime.Now.ToString();
                cmd.Parameters.AddWithValue("@datestamp", d);
                int count = cmd.ExecuteNonQuery();
                txtHOM.Text = "";
                if (count == 1)
                {
                    gvImages.DataSource = SqlDataSource3;
                    gvImages.DataBind();
                }
                connection.Close();
                LoadImages(); // Reload lab reports after upload
            }
        }
  

        protected void txtImName_TextChanged(object sender, EventArgs e)
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

            if (txtHOM.Text == "DEL")
            {
                string val = Session["smrn"].ToString();
                String mycon = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                String updatedata = "delete from Images where datestamp='" + DateTime.Now + "'and patient_id=" + val;
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                gvImages.DataSource = SqlDataSource3;
                gvImages.DataBind();
                txtHOM.Text = "";
            }
        }
    }
}