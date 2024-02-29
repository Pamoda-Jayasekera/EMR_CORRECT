using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Globalization;
using System;

namespace EMR
{
    public partial class DOCFinalPrediction : System.Web.UI.Page
    {
        private bool isSubmitClicked = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            Session["hom"] = "DOC";

            if (!IsPostBack)
            {
                if (PreviousPage != null)
                {
                    TextBox txtMRN = (TextBox)PreviousPage.FindControl("txtMRN");
                    if (txtMRN != null)
                    {
                        string patientId = txtMRN.Text.Trim();
                        if (!string.IsNullOrEmpty(patientId))
                        {
                            Session["smrn"] = patientId;
                        }
                    }
                }
            }

            if (isSubmitClicked)
            {
                resultLabel.Text = "Data successfully submitted!";
                resultLabel.ForeColor = System.Drawing.Color.Green;
            }
        }



        protected void showDetailsButton_Click(object sender, EventArgs e)
        {

           
                string predictionIdValue = predictionId.Text.Trim();

                if (!string.IsNullOrEmpty(predictionIdValue))
                {
                    predictionIdHidden.Value = predictionIdValue;

                    string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT patient_id, symptom, prediction FROM Prediction WHERE prediction_id = @PredictionId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@PredictionId", predictionIdValue);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string patientId = reader["patient_id"].ToString();
                            string symptom = reader["symptom"].ToString();
                            string predictedDisease = reader["prediction"].ToString();

                            resultLabel.Visible = true;
                            resultLabel.Text = $"Patient ID: {patientId}<br />Symptom: {symptom}<br />Predicted Disease: {predictedDisease}";

                            string moreDetails = predictedDisease;
                            DisplayDataInTable(moreDetails);

                            // Check if there are existing orders and populate txtDiagnosis
                            string existingOrders = GetExistingOrders(predictionIdValue);
                            txtDiagnosis.Text = existingOrders;
                        }
                        else
                        {
                            resultLabel.Visible = true;
                            resultLabel.Text = "Prediction ID not found.";
                        }

                        reader.Close();
                    }
                }
                else
                {
                    resultLabel.Visible = true;
                    resultLabel.Text = "Please enter a Prediction ID.";
                }
        

        }



        private void DisplayDataInTable(string predictedDisease)
        {
            // Clear previous content
            lblDagnosis.Text = "";
            lblTreatmentBasis.Text = "";
            lblTreatmentOptions.Text = "";
            txtDiagnosis.Text = "";
            // lblOrders.Controls.Clear();

            // This section is modified to fix the issue with the if-else block
            if (predictedDisease == "Chronic cholestasis")
            {
                // Set the initial multi-line text
                lblDagnosis.Controls.Add(new LiteralControl("Blood tests to detect the presence of the parasite and Thick and thin blood smears<br>"));
                // Add additional lines of diagnosis text
                lblDagnosis.Controls.Add(new LiteralControl("Rapid diagnostic tests (RDTs)<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Polymerase chain reaction (PCR)<br><br>"));
                // Add a hyperlink
                HyperLink assignTestLink = new HyperLink
                {
                    Text = "Assign Test for the patient",
                    NavigateUrl = "TestDisease.aspx"
                };
                lblDagnosis.Controls.Add(assignTestLink);
                lblTreatmentBasis.Text = "Antimalarial medication, supportive care";
               // lblOrders.Controls.Add(new HyperLink { Text = "Orders for Disease A", NavigateUrl = "https://docs.google.com/document/d/1JX0AAxrryM1EJVp-9UNTewbO0AjAA_md/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Disease A", NavigateUrl = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }

            else if (predictedDisease == "Autoimmune Hepatitis")
            {
                // Set the initial multi-line text
                lblDagnosis.Controls.Add(new LiteralControl("Blood tests to detect the presence of the parasite and Thick and thin blood smears<br>"));
               
                lblTreatmentBasis.Text = "Antimalarial medication, supportive care";
               // lblOrders.Controls.Add(new HyperLink { Text = "Orders for Disease A", NavigateUrl = "https://docs.google.com/document/d/1JX0AAxrryM1EJVp-9UNTewbO0AjAA_md/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Disease A", NavigateUrl = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }


            else if (predictedDisease == "Drug Reaction")
            {
                // Set the initial multi-line text
                lblDagnosis.Controls.Add(new LiteralControl("Blood tests to detect the presence of the parasite and Thick and thin blood smears<br>"));
                // Add additional lines of diagnosis text
                lblDagnosis.Controls.Add(new LiteralControl("Rapid diagnostic tests (RDTs)<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Polymerase chain reaction (PCR)<br><br>"));
                // Add a hyperlink
                HyperLink assignTestLink = new HyperLink
                {
                    Text = "Assign Test for the patient",
                    NavigateUrl = "TestDisease.aspx"
                };
                lblDagnosis.Controls.Add(assignTestLink);
                lblTreatmentBasis.Text = "Antimalarial medication, supportive care";
                // lblOrders.Controls.Add(new HyperLink { Text = "Orders for Disease A", NavigateUrl = "https://docs.google.com/document/d/1JX0AAxrryM1EJVp-9UNTewbO0AjAA_md/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Disease A", NavigateUrl = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }

            else if (predictedDisease == "Migraine")
            {
                // Set the initial multi-line text
                lblDagnosis.Controls.Add(new LiteralControl("Blood tests to detect the presence of the parasite and Thick and thin blood smears<br>"));
                // Add additional lines of diagnosis text
                lblDagnosis.Controls.Add(new LiteralControl("Rapid diagnostic tests (RDTs)<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Polymerase chain reaction (PCR)<br><br>"));
                // Add a hyperlink
                HyperLink assignTestLink = new HyperLink
                {
                    Text = "Assign Test for the patient",
                    NavigateUrl = "TestDisease.aspx"
                };
                lblDagnosis.Controls.Add(assignTestLink);
                lblTreatmentBasis.Text = "Antimalarial medication, supportive care";
               // lblOrders.Controls.Add(new HyperLink { Text = "Orders for Disease A", NavigateUrl = "https://docs.google.com/document/d/1JX0AAxrryM1EJVp-9UNTewbO0AjAA_md/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Disease A", NavigateUrl = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }

           
            else if (predictedDisease == "Chicken pox")
            {
                // Set the initial multi-line text
                lblDagnosis.Controls.Add(new LiteralControl("Clinical symptoms and history of exposure to the virus that causes chickenpox.<br>"));
                // Add a hyperlink
                HyperLink assignTestLink = new HyperLink
                {
                    Text = "Assign Test for the patient",
                    NavigateUrl = "TestDisease.aspx"
                };
                lblDagnosis.Controls.Add(assignTestLink);
                lblTreatmentBasis.Text = "Symptomatic treatment, antiviral medication";
              //  lblOrders.Controls.Add(new HyperLink { Text = "Orders for Chicken pox", NavigateUrl = "https://docs.google.com/document/d/11q7S58mFpS-2Q-jV5SAlGV5gZ9SDhUlD/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Chicken pox", NavigateUrl = "https://docs.google.com/document/d/1iJZdE3ce4eVoihRuGCbJfBOhbM3sgKfa/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }


            else if (predictedDisease == "Heart attack")
            {
                // Add additional lines of diagnosis text
                lblDagnosis.Controls.Add(new LiteralControl("ECG<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Echocardiogram<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Cardiac catheterization<br>"));
                lblDagnosis.Controls.Add(new LiteralControl("Blood Test<br><br>"));
                // Add a hyperlink
                HyperLink assignTestLink = new HyperLink
                {
                    Text = "Assign Test for the patient",
                    NavigateUrl = "TestDisease.aspx"
                };
                lblDagnosis.Controls.Add(assignTestLink);
                lblTreatmentBasis.Text = "Emergency medical care, aspirin, nitroglycerin, thrombolytic therapy, angioplasty, stent placement, or CABG";
              //  lblOrders.Controls.Add(new HyperLink { Text = "Orders for Heart attack", NavigateUrl = "https://docs.google.com/document/d/1kZM_ifKQEJeuOr6nwJF4YaOIBI2dqsTW/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Heart attack", NavigateUrl = "https://docs.google.com/document/d/1a4Wnxzw-oA9oW-No-P0QMCMN0KIFqsWr/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
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

        protected void fetchDataButton_Click(object sender, EventArgs e)
        {
            string patientId = Session["smrn"].ToString();
            string datestamp = txtDateP.Text.Trim(); // Assuming txtDateP is the ID of your date textbox

            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                

                string query = "SELECT prediction_id, symptom, prediction FROM Prediction WHERE patient_id = @PatientId AND datestamp = @Datestamp";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);
                command.Parameters.AddWithValue("@Datestamp", DateTime.ParseExact(datestamp, "yyyy-MM-dd", CultureInfo.InvariantCulture));

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataTable.Columns.Add("Rank", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["Rank"] = i + 1;
                    }

                    GridView1.DataSource = dataTable;
                    GridView1.DataBind();
                    resultLabel.Text = $"Data retrieved for Patient ID: {patientId} and Datestamp: {datestamp}";
                }
                else
                {
                    resultLabel.Text = "No data found for the given Patient ID and Datestamp.";
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnSubmitDiagnosis_Click(object sender, EventArgs e)
        {
            // Get the prediction ID from the hidden field
            string predictionId = predictionIdHidden.Value;
            string diagnosisText = txtDiagnosis.Text.Trim();

            // Create a connection to your database
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the prediction ID exists in the database
                string checkQuery = "SELECT COUNT(*) FROM Prediction WHERE prediction_id = @PredictionId";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@PredictionId", predictionId);

                int predictionCount = (int)checkCommand.ExecuteScalar();

                if (predictionCount > 0)
                {
                    // The prediction ID exists; update the existing record
                    string updateQuery = "UPDATE Prediction SET orders = @DiagnosisText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.Parameters.AddWithValue("@DiagnosisText", diagnosisText);
                    updateCommand.ExecuteNonQuery();

                    string script = "alert('Diagnosis updated successfully!');";
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);
                }
                else
                {
                    // The prediction ID does not exist
                    string script = "alert('Prediction ID not found. Please enter a valid Prediction ID.');";
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", script, true);
                }

                connection.Close();
            }
        }


        protected void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            // Your logic for the text changed event here
        }

        private string GetExistingOrders(string predictionId)
        {
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            string orders = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT orders FROM Prediction WHERE prediction_id = @PredictionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PredictionId", predictionId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    orders = reader["orders"].ToString();
                }

                reader.Close();
            }

            return orders;
        }
    }
}