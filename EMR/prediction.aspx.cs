using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace EMR
{
    public partial class prediction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            txtHOM.Focus();

            if (!IsPostBack)
            {
                // Load the existing symptoms from the bigTextBox and display them
                string savedSymptoms = txtSymptoms.Text;
                if (!string.IsNullOrEmpty(savedSymptoms))
                {
                    txtSymptoms.Text = savedSymptoms;
                }
            }


            // Check if the query parameter is present
            if (!string.IsNullOrEmpty(Request.QueryString["disease"]))
            {
                string predictedDisease = Request.QueryString["disease"];
                lblPrediction.Text = predictedDisease;

            }

        }

        //NRE CODE CHANGES 11/11
        protected void btnPredict_Click(object sender, EventArgs e)
        {
            string userSymptoms = txtSymptoms.Text;
            string symptom = txtHOM.Text.Trim();

            // Add new symptom to the list if it's not empty
            if (!string.IsNullOrEmpty(symptom))
            {
                userSymptoms = string.IsNullOrEmpty(userSymptoms) ? symptom : $"{userSymptoms},{symptom}";
                txtHOM.Text = "";
            }

            // Retrieve patientId from session or wherever you store it just once
            string patientId = Session["smrn"].ToString();

            // Get the current date just once
            DateTime currentDate = DateTime.Now.Date;

            try
            {
                // Create a request to the Flask API endpoint
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/predict");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";

                // Encode the user input and create the request content
                string postData = $"symptoms={HttpUtility.UrlEncode(userSymptoms)}";
                byte[] postDataBytes = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = postDataBytes.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(postDataBytes, 0, postDataBytes.Length);
                }

                // Get the response from the API
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string responseBody = reader.ReadToEnd();
                    JObject jsonResponse = JObject.Parse(responseBody); // Parse the JSON response

                    // Check if predicted_diseases is not null and is an array
                    if (jsonResponse["predicted_diseases"] is JArray predictedDiseasesArray)
                    {
                        List<string> predictedDiseases = new List<string>();

                        foreach (var item in predictedDiseasesArray)
                        {
                            // Parse the disease name and probability
                            string fullDiseaseInfo = item.ToString();
                            predictedDiseases.Add(fullDiseaseInfo);

                            // Save the prediction details to the database
                            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True"))
                            {
                                con.Open();
                                string insertQuery = "INSERT INTO Prediction (patient_id, symptom, prediction, datestamp, rank) VALUES (@patient_id, @symptom, @prediction, @datestamp, @rank)";
                                using (SqlCommand command = new SqlCommand(insertQuery, con))
                                {
                                    command.Parameters.AddWithValue("@patient_id", patientId);
                                    command.Parameters.AddWithValue("@symptom", userSymptoms);
                                    command.Parameters.AddWithValue("@prediction", fullDiseaseInfo);
                                    command.Parameters.AddWithValue("@datestamp", currentDate);
                                    command.Parameters.AddWithValue("@rank", 1); // Assuming rank is a static value here

                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        // Display all predicted diseases
                        lblPrediction.Text = "<h2>Ranked Probable Illnesses Based on Symptoms</h2><ol style=\"text-align: left;\">";
                        foreach (var predictedDisease in predictedDiseases)
                        {
                            lblPrediction.Text += $"<li>{predictedDisease}</li>";
                        }
                        lblPrediction.Text += "</ol>";
                    }
                    else
                    {
                        lblPrediction.Text = "No predicted diseases were found.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblPrediction.Text = "An error occurred: " + ex.Message;
            }
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
        }

      
    }
}


