using System;
using System.Data.SqlClient;

namespace EMR
{
    public partial class prediction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

           
            txtHOM.Focus();
            if (!IsPostBack)
            {
                // Load the existing symptoms from the bigTextBox and display them
                string savedSymptoms = bigTextBox.Text;
                if (!string.IsNullOrEmpty(savedSymptoms))
                {
                    bigTextBox.Text = savedSymptoms;
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string symptom = txtHOM.Text.Trim();
            if (!string.IsNullOrEmpty(symptom))
            {
                if (!string.IsNullOrEmpty(bigTextBox.Text))
                {
                    // Append with comma after the last symptom
                    bigTextBox.Text += "," + symptom;
                }
                else
                {
                    // First symptom, no comma needed
                    bigTextBox.Text = symptom;
                }

                txtHOM.Text = "";
            }
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True";

                // Check the value of val before insertion
                string val = Session["smrn"]?.ToString();
                if (string.IsNullOrEmpty(val))
                {
                    Response.Write("Error: patient_id (val) is null or empty.");
                    return;
                }

                string symptom = bigTextBox.Text.Trim();
                Response.Write("symptom: " + symptom);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Prediction (symptom, patient_id, datestamp) VALUES (@symptom, @patientId, @datestamp)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@symptom", symptom);
                    command.Parameters.AddWithValue("@patientId", val);
                    command.Parameters.AddWithValue("@datestamp", DateTime.Now); // Capture the current date and time
                    command.ExecuteNonQuery();
                }

                // Redirect to FinalPrediction.aspx after successful insertion.
                Response.Redirect("FinalPrediction.aspx");
            }
            catch (Exception ex)
            {
                // Handle exceptions if necessary.
                // For simplicity, display the exception message to help identify issues during debugging.
                Response.Write("An error occurred: " + ex.Message);
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
