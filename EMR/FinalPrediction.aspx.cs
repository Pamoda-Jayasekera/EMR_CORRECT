using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web;

namespace EMR
{
    public partial class FinalPrediction : System.Web.UI.Page
    {
        private string connectionString = @"Data Source = DESKTOP - NRUK56G; Initial Catalog = EMR_DB; Integrated Security = True";

        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack)
            {
                if (Request.QueryString["prediction"] != null)
                {
                    string predictedDisease = Request.QueryString["prediction"];
                    lblPrediction.Text = "Predicted Disease: " + predictedDisease;

                    // Use the predictedDisease value to update data in the table
                    DisplayDataInTable(predictedDisease);
                }
            }
        }

      
        private void DisplayDataInTable(string predictedDisease)
        {

            // Use a switch or if-else statements to determine the data to display based on predictedDisease
            // Update 'treatment_basis', 'orders', and 'treatment_options' accordingly
            if (predictedDisease == "Fungal infection")
            {
               
                lblTreatmentBasis.Text = "Treatment Basis for Disease A";
                lblOrders.Text = "https://docs.google.com/document/d/11q7S58mFpS-2Q-jV5SAlGV5gZ9SDhUlD/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
                lblTreatmentOptions.Text = "Treatment Options for Disease A";
            }
            else if (predictedDisease == "Chicken pox")
            {
               
                lblTreatmentBasis.Text = "Symptomatic treatment, antiviral medication";
                lblOrders.Text = "https://docs.google.com/document/d/11q7S58mFpS-2Q-jV5SAlGV5gZ9SDhUlD/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
                lblTreatmentOptions.Text = "https://docs.google.com/document/d/1iJZdE3ce4eVoihRuGCbJfBOhbM3sgKfa/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
            }

            else if (predictedDisease == "Malaria")
            {
              
                lblTreatmentBasis.Text = "Antimalarial medication, supportive care";
                lblOrders.Text = "https://docs.google.com/document/d/1JX0AAxrryM1EJVp-9UNTewbO0AjAA_md/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
                lblTreatmentOptions.Text = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
            }

            else if (predictedDisease == "Heart attack")
            {
              
                lblOrders.Text = "https://docs.google.com/document/d/1kZM_ifKQEJeuOr6nwJF4YaOIBI2dqsTW/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
                lblTreatmentOptions.Text = "https://docs.google.com/document/d/1a4Wnxzw-oA9oW-No-P0QMCMN0KIFqsWr/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true";
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

        protected void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            // Get the prediction ID from lblPredictionID
            string predictionId = lblPredictionID.Text.Trim();
            string diagnosisText = txtDiagnosis.Text.Trim();

            // Create a connection to your database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the prediction_id already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM PredictionTable WHERE prediction_id = @PredictionId";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                int existingRecords = (int)checkCommand.ExecuteScalar();

                if (existingRecords > 0)
                {
                    // Update the existing record with the new diagnosis text
                    string updateQuery = "UPDATE PredictionTable SET orders = @DiagnosisText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@DiagnosisText", diagnosisText);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insert a new record with the prediction_id and diagnosis text
                    string insertQuery = "INSERT INTO PredictionTable (prediction_id, orders) VALUES (@PredictionId, @DiagnosisText)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    insertCommand.Parameters.AddWithValue("@DiagnosisText", diagnosisText);
                    insertCommand.ExecuteNonQuery();
                }

                // Close the database connection
                connection.Close();
            }

            // Show a pop-up message using JavaScript to confirm the save
            string script = "alert('Diagnosis saved successfully!');";
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);
        }








    }


}
