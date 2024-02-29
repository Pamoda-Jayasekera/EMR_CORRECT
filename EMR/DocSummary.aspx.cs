using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Globalization;
using System;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Text;


namespace EMR
{
    public partial class DocSummary : System.Web.UI.Page
    {
        private const string ConnectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";



        private bool isSubmitClicked = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            Session["hom"] = "DOC";

            if (!IsPostBack)
            {
                // Check if the MRN is available from the PreviousPage
                if (PreviousPage != null)
                {
                    TextBox txtMRN = (TextBox)PreviousPage.FindControl("txtMRN");
                    if (txtMRN != null && !string.IsNullOrEmpty(txtMRN.Text.Trim()))
                    {
                        Session["smrn"] = txtMRN.Text.Trim();
                    }
                }

                // If MRN is available in the session, load the lab reports
                if (Session["smrn"] != null)
                {
                    LoadLabReports(Session["smrn"].ToString());

                    string patientId = Session["smrn"].ToString();

                    // Load existing data from both Order and Prediction tables
                    LoadExistingOrderData(patientId);
                 
                }
            }
            if (isSubmitClicked)
            {
                resultLabel.Text = "Data successfully submitted!";
                resultLabel.ForeColor = System.Drawing.Color.Green;
            }


        }

        //NEW CODE 
        private void LoadExistingOrderData(string patientId)
        {
            StringBuilder orderData = new StringBuilder();
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Retrieve order data
                string query = "SELECT type, description, dosage FROM [Order] WHERE patient_id = @patientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patientId", patientId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string type = reader["type"].ToString();
                        string description = reader["description"].ToString();
                        string dosage = reader["dosage"].ToString();

                        orderData.AppendLine($"{type} - {description} - {dosage}");
                    }
                }

                // Update the medication column in the Prediction table
                if (orderData.Length > 0)
                {
                    string updateQuery = "UPDATE Prediction SET medication = @OrderData WHERE patient_id = @PatientId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PatientId", patientId);
                    updateCommand.Parameters.AddWithValue("@OrderData", orderData.ToString());
                    updateCommand.ExecuteNonQuery();
                }
            }

            // Display the concatenated order data in the txtDiagnosisMed text box
            txtDiagnosisMed.Text = orderData.ToString();
        }











        private void LoadLabReports(string patientId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT image_name FROM Images WHERE patient_id = @PatientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvLabReports.DataSource = dt;
                gvLabReports.DataBind();
            }
        }


        protected void btnShowSelectedImages_Click(object sender, EventArgs e)
        {
            phSelectedImages.Controls.Clear();

            foreach (GridViewRow row in gvLabReports.Rows)
            {
                CheckBox chkSelect = row.FindControl("chkSelect") as CheckBox;
                if (chkSelect != null && chkSelect.Checked)
                {
                    string imageName = row.Cells[1].Text;
                    byte[] imageData = GetImageData(Session["smrn"].ToString(), imageName);

                    if (imageData != null)
                    {
                        string imageBase64 = Convert.ToBase64String(imageData);
                        string imageUrl = $"data:image/jpg;base64,{imageBase64}";

                        // Add image name label
                        Label lblImageName = new Label();
                        lblImageName.Text = imageName;
                        lblImageName.CssClass = "image-name-class"; // Optional: for styling
                        phSelectedImages.Controls.Add(lblImageName);

                        // Add a line break
                        phSelectedImages.Controls.Add(new LiteralControl("<br />"));

                        // Add image
                        HtmlImage img = new HtmlImage
                        {
                            Src = imageUrl,
                            Alt = imageName
                        };

                        // Set the width to 100% and let the height auto adjust
                        img.Style.Add(HtmlTextWriterStyle.Width, "100%");
                        img.Style.Add(HtmlTextWriterStyle.Height, "auto");

                        phSelectedImages.Controls.Add(img);

                        // Add another line break for spacing
                        phSelectedImages.Controls.Add(new LiteralControl("<br /><br />"));
                    }
                }
            }
        }



        private byte[] GetImageData(string patientId, string imageName)
        {
            byte[] imageData = null;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT image FROM Images WHERE patient_id = @PatientId AND image_name = @ImageName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);
                command.Parameters.AddWithValue("@ImageName", imageName);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    imageData = (byte[])result;
                }
            }

            return imageData;
        }

        //THE NEW CODE 
        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            string text = txtHOM.Text;
            Regex regexForPID = new Regex(@"\bPID (\d+)$");
           // Regex regexForPID = new Regex(@"^(.+)\bPID$");
            Regex regexForORD = new Regex(@"^(.+)\bORD$");
            Regex regexForRST = new Regex(@"^(.+)\bRST$");
            Regex regexForMDN = new Regex(@"^(.+)\bMDN$");
            Regex regexForTPS = new Regex(@"^(.+)\bTPS$");

            Match matchForPID = regexForPID.Match(text);
            Match matchForORD = regexForORD.Match(text);
            Match matchForRST = regexForRST.Match(text);
            Match matchForMDN = regexForMDN.Match(text);
            Match matchForTPS = regexForTPS.Match(text);

            if (matchForPID.Success)
            {
                string predictionIdValue = matchForPID.Groups[1].Value;

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

                            string existingOrders = GetExistingOrders(predictionIdValue);
                            txtDiagnosis.Text = existingOrders;

                            string existingResults = GetExistingResults(predictionIdValue);
                            txtDiagnosisResults.Text = existingResults;

                            string existingMedication = GetExistingMeds(predictionIdValue);
                            txtDiagnosisMed.Text = existingMedication;

                            string existingTreatment = GetExistingTreatments(predictionIdValue);
                            txtDiagnosisTreatment.Text = existingTreatment;


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

            //NEW CODE 2 11/11
            else if (matchForORD.Success)
            {
                string diagnosisText = matchForORD.Groups[1].Value.Trim();
                txtDiagnosis.Text = diagnosisText;

                string predictionId = predictionIdHidden.Value;
                string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Prediction SET orders = @DiagnosisText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.Parameters.AddWithValue("@DiagnosisText", diagnosisText);
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }

            // RESULTS ('RST')
            else if (matchForRST.Success)
            {
                string resultsText = matchForRST.Groups[1].Value.Trim();
                txtDiagnosisResults.Text = resultsText;

                string predictionId = predictionIdHidden.Value;
                string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Prediction SET results = @ResultsText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.Parameters.AddWithValue("@ResultsText", resultsText);
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }

            // MEDICATION ('MDN')
            else if (matchForMDN.Success)
            {
                string newMedicationText = matchForMDN.Groups[1].Value.Trim();
                string predictionId = predictionIdHidden.Value;
                string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                string updatedMedicationText = ""; // Declare outside the using block

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve existing medication data
                    string existingMedicationQuery = "SELECT medication FROM Prediction WHERE prediction_id = @PredictionId";
                    SqlCommand existingMedicationCommand = new SqlCommand(existingMedicationQuery, connection);
                    existingMedicationCommand.Parameters.AddWithValue("@PredictionId", predictionId);

                    string existingMedication = (string)existingMedicationCommand.ExecuteScalar() ?? "";

                    // Concatenate new medication text with existing data
                    updatedMedicationText = existingMedication + Environment.NewLine + newMedicationText;

                    // Update the medication column with the concatenated data
                    string updateQuery = "UPDATE Prediction SET medication = @MedicationText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.Parameters.AddWithValue("@MedicationText", updatedMedicationText);
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }

                // Update the text box to reflect the concatenated data
                txtDiagnosisMed.Text = updatedMedicationText;
            }

            // TREATMENT PLANS ('TPS')
            else if (matchForTPS.Success)
            {
                string treatmentPlanText = matchForTPS.Groups[1].Value.Trim();
                txtDiagnosisTreatment.Text = treatmentPlanText; // Ensure this TextBox ID is correct

                string predictionId = predictionIdHidden.Value;
                string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Prediction SET treatmentPlan = @TreatmentPlanText WHERE prediction_id = @PredictionId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                    updateCommand.Parameters.AddWithValue("@TreatmentPlanText", treatmentPlanText);
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }



            else
            {
                resultLabel.Visible = true;
                resultLabel.Text = "Invalid input format.";
            }

            // Handle the HOM navigation
            if (text == "HOM")
            {
                if (Session["hom"] != null)
                {
                    string prev = Session["hom"].ToString();
                    if (prev == "DOC")
                    {
                        Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
                    }
                    if (prev == "MA")
                    {
                        Response.Redirect("MADashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
                    }
                    // New condition for when prev is "PT"
                    if (txtHOM.Text == "HOM" && prev == "PT")
                    {
                        txtHOM.Text = "";
                        Response.Redirect("PatientDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
                    }
                }
            }

            txtHOM.Text = ""; // Clear the txtHOM after processing
        }


        private void DisplayDataInTable(string predictedDisease)
        {
            // Clear previous content
          
            lblTreatmentOptions.Text = "";
            txtDiagnosis.Text = "";
          

            // This section is modified to fix the issue with the if-else block
            if (predictedDisease == "Chronic cholestasis")
            {
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Chronic cholestasis", NavigateUrl = "https://docs.google.com/document/d/1dPFohuqoZot9RWycBkO_Q4eqVw-akLom/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }

            else if (predictedDisease == "Heart attack")
            {
                lblTreatmentOptions.Controls.Add(new HyperLink { Text = "Treatment Options for Heart attack", NavigateUrl = "https://docs.google.com/document/d/1a4Wnxzw-oA9oW-No-P0QMCMN0KIFqsWr/edit?usp=sharing&ouid=100117484703353925082&rtpof=true&sd=true" });
            }
        }

        protected void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {
            
        }

     /*   protected void txtRef_TextChanged(object sender, EventArgs e)
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

        }*/

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

        private string GetExistingResults(string predictionId)
        {
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            string results = "";
            //result
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT results FROM Prediction WHERE prediction_id = @PredictionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PredictionId", predictionId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    results = reader["results"].ToString();
                }

                reader.Close();
            }

            return results;
        }
        private string GetExistingMeds(string predictionId)
        {
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            string medication = "";
            //med
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT medication FROM Prediction WHERE prediction_id = @PredictionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PredictionId", predictionId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    medication = reader["medication"].ToString();
                }

                reader.Close();
            }

            return medication;
        }
        private string GetExistingTreatments(string predictionId)
        {
            string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";
            string treatmentPlan = "";
            //treatment
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT treatmentPlan FROM Prediction WHERE prediction_id = @PredictionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PredictionId", predictionId);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    treatmentPlan = reader["treatmentPlan"].ToString();
                }

                reader.Close();
            }

            return treatmentPlan;
        }


        //new code 11/11
       /* private void UpdateDatabaseField(string fieldName, string fieldValue)
        {
            string predictionId = predictionIdHidden.Value;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string updateQuery = $"UPDATE Prediction SET {fieldName} = @FieldValue WHERE prediction_id = @PredictionId";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@FieldValue", fieldValue);
                updateCommand.Parameters.AddWithValue("@PredictionId", predictionId);
                updateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
       */




    }
}