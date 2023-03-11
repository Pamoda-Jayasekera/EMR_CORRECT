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
    public partial class Images : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack)
            {
                gvImages.DataSource = SqlDataSource3;
                gvImages.DataBind();
            }
        }
        /*  protected void loadImages()
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
          }*/
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