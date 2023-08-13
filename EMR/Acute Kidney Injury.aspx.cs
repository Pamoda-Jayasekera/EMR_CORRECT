using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class Acute_Kidney_Injury : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Fetch and display the patient ID from the database
                int patientId = GetPatientId(); // Replace this with your database query to retrieve the patient ID
               
            }
        }

        // Replace this method with your database query to retrieve the patient ID
        private int GetPatientId()
        {
            // Your database query to get the patient ID goes here
            // For now, return a sample patient ID (you need to replace this)
            return 12345;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Save the details of the checked boxes to the database
           
        }

        // Replace this method with your database insert query to save the test details
        private void SaveTestDetails(int patientId, string testType)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO TestDetails (PatientID, TestType) VALUES (@PatientID, @TestType)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PatientID", patientId);
                    command.Parameters.AddWithValue("@TestType", testType);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary.
                Response.Write("An error occurred while saving test details: " + ex.Message);
            }
        }
    }
}
