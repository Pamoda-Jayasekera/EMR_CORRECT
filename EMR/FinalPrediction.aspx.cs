using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class FinalPrediction : System.Web.UI.Page
    {
      
      
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                // Fetch and display the prediction for the given patient_id and prediction_id
                int patientId = 0; // Replace 0 with the actual patient_id you want to retrieve predictions for.
                int predictionId = 0; // Replace 0 with the actual prediction_id you want to retrieve.

                string predictionText = GetPredictionText(patientId, predictionId);
                txtPrediction.Text = predictionText;
            }
            }

        private string GetPredictionText(int patientId, int predictionId)
        {
            // Your existing database connection code
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";

            string predictionText = "";
            string symptoms = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch the predicted illness from the database based on patientId and predictionId
                    string illnessQuery = "SELECT prediction FROM Prediction WHERE patient_id = @patientId AND prediction_id = @predictionId";
                    SqlCommand illnessCommand = new SqlCommand(illnessQuery, connection);
                    illnessCommand.Parameters.AddWithValue("@patientId", patientId);
                    illnessCommand.Parameters.AddWithValue("@predictionId", predictionId);

                    object illnessResult = illnessCommand.ExecuteScalar();
                    if (illnessResult != null)
                    {
                        predictionText = illnessResult.ToString();
                    }

                    // Fetch the predicted symptoms from the database based on patientId and predictionId
                    string symptomsQuery = "SELECT symptom FROM Prediction WHERE patient_id = @patientId AND prediction_id = @predictionId";
                    SqlCommand symptomsCommand = new SqlCommand(symptomsQuery, connection);
                    symptomsCommand.Parameters.AddWithValue("@patientId", patientId);
                    symptomsCommand.Parameters.AddWithValue("@predictionId", predictionId);

                    using (SqlDataReader reader = symptomsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string symptom = reader["symptom"].ToString();
                            symptoms += symptom + ", ";
                        }
                    }

                    // Remove the last comma and space from the symptoms string
                    if (!string.IsNullOrEmpty(symptoms))
                    {
                        symptoms = symptoms.TrimEnd(',', ' ');
                    }
                }

                // Based on the prediction text, set the links for treatment order and treatment basis
                switch (predictionText)
                {
                    case "Acute Kidney Injury":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1VFqNdi09yaI0_5n39Od7_iX2dJmKNHWl/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/1o37GYs3o2AM389qkXjCpRIE1nOemN_t9/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    case "Alcoholic Liver Disease":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1VcG3J1Ion6rfG0VsRrt8kACc1W0oDQxL/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/1g58oySLpnoXfq_5bUyME87Sh7ZQFM8jO/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    case "Alkaptonuria":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1vQ8jEw3oOaV89l17qpGFGcEGzmBSHpmv/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/1-EKVjmT0eFz_8X6pwNh64xo1Xjz8SQ3h/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    case "Aortic Aneurysm":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1NR6I1I96l9pJucOb3gm01DJi-0Idzgy8/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/1x6FXOfK779OdP9p249FuJMQae9aBIh8A/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    case "Arrhythmia":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1P6_Xv3uhYn7NFiN0H2mcJYblqfEOSG4B/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/1r1ACBUMg74pZ7D9_ZEGmGprFhUG49Mxz/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    case "Asthma":
                        hlTreatmentOrder.NavigateUrl = "https://docs.google.com/document/d/1Cl1QXhgUyxmaR-CQ2eqs6Zjh88xyIjS5/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        hlTreatmentBasis.NavigateUrl = "https://docs.google.com/document/d/11uZs8KQCVRXCK-9F16ClQ_I16koVUibt/edit?usp=drive_link&ouid=100117484703353925082&rtpof=true&sd=true";
                        break;
                    default:
                        // Set default URLs if no specific disease is matched
                        hlTreatmentOrder.NavigateUrl = "default_treatment_order_url";
                        hlTreatmentBasis.NavigateUrl = "default_treatment_basis_url";
                        break;
                }

                // Concatenate the predicted symptoms with the predicted illness
                predictionText = $"{predictionText} - Predicted Symptoms: {symptoms}";
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary.
                // For simplicity, you can display the exception message during debugging.
                predictionText = "An error occurred: " + ex.Message;
            }

            return predictionText;
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
