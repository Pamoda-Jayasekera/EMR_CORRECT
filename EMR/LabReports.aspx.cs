using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

namespace EMR
{
    public partial class LabReports : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource3;
                GridView1.DataBind();
            }
        }
        protected void Upload(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        string val = Session["smrn"].ToString();
                        string query = "Insert into Lab_Reports values (@patient_id, @description, @Lab_Name, @Content_Type, @Lab_Report, @datestamp)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@patient_id", val);
                            cmd.Parameters.AddWithValue("@description", "Description goes here");
                            cmd.Parameters.AddWithValue("@Lab_Name", txtHOM.Text);
                            cmd.Parameters.AddWithValue("@Content_Type", contentType);
                            cmd.Parameters.AddWithValue("@Lab_Report", bytes);
                            string d = DateTime.Now.ToString();
                            cmd.Parameters.AddWithValue("@datestamp", d);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                    }
                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);

        }


        protected void DownloadFile(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Lab_Name, Lab_Report, Content_Type from Lab_Reports where patient_id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Lab_Report"];
                        contentType = sdr["Content_Type"].ToString();
                        fileName = sdr["Lab_Name"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }


        //new code 10/1/2023
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Prediction_id from the TextBox
                string predictionId = txtPredictionId.Text;

                // Get the summary from the textarea
                string summary = txtSummary.Text;

                // Create a DataTable to store test name and test results
                DataTable dt = new DataTable();
                dt.Columns.Add("TestName", typeof(string));
                dt.Columns.Add("TestResults", typeof(string));

                // Iterate through the table rows to collect test data
                foreach (GridViewRow row in testTable.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox txtTestName = (TextBox)row.FindControl("txtTestName");
                        TextBox txtTestResults = (TextBox)row.FindControl("txtTestResults");

                        // Add the test data to the DataTable
                        dt.Rows.Add(txtTestName.Text, txtTestResults.Text);
                    }
                }

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlTransaction transaction = con.BeginTransaction())
                    {
                        try
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                string testName = row["TestName"].ToString();
                                string testResults = row["TestResults"].ToString();
                              

                                string insertQuery = "INSERT INTO LabTestResults (prediction_id, test_name, test_results) VALUES (@predictionId, @testName, @testResults)";
                                using (SqlCommand cmd = new SqlCommand(insertQuery, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@predictionId", predictionId);
                                    cmd.Parameters.AddWithValue("@testName", testName);
                                    cmd.Parameters.AddWithValue("@testResults", testResults);
                                    cmd.ExecuteNonQuery();
                                }

                                string updateQuery = "UPDATE Prediction SET symptoms = symptoms + @summary WHERE prediction_id = @predictionId";
                                using (SqlCommand cmd = new SqlCommand(updateQuery, con, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@summary", summary);
                                    cmd.Parameters.AddWithValue("@predictionId", predictionId);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Commit the transaction if everything is successful
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions or errors that may occur during data saving
                            // You can log the error or display it to the user
                            transaction.Rollback(); // Rollback the transaction in case of an error
                                                    // Example: lblMessage.Text = "An error occurred: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur before database operations (e.g., connection opening)
                // Example: lblMessage.Text = "An error occurred: " + ex.Message;
            }
        }




        /*protected void DownloadFile(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            byte[] bytes;
            string fileName, contentType;
            string constr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Lab_Name, Lab_Report, Content_Type from Lab_Reports where patient_id=@Id";
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        bytes = (byte[])sdr["Lab_Report"];
                        contentType = sdr["ContentType"].ToString();
                        fileName = sdr["Lab_Name"].ToString();
                    }
                    con.Close();
                }
            }
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = contentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }*/
        protected void txtLabName_TextChanged(object sender, EventArgs e)
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
            


                else if (txtHOM.Text == "DEL")
                {
                    string val = Session["smrn"].ToString();
                    String mycon = @"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                    String updatedata = "delete from Lab_Reports where datestamp='" + DateTime.Now + "'and patient_id=" + val;
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = updatedata;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    txtHOM.Text = "";
                    GridView1.DataSource = SqlDataSource3;
                    GridView1.DataBind();
                }
            }
        }
    }



    

