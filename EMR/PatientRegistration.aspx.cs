using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
namespace EMR
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            txtRBClerk.Focus();
            

        }

       

        protected void txtRBClerk_TextChanged(object sender, EventArgs e)
        {
            if (txtRBClerk.Text.Length > 4)
            {
                if (txtRBClerk.Text == "LOGOUT")
                {
                    txtRBClerk.Text = "";
                    btnLogOut_Click(sender, e);
                }
                string rbtxt = txtRBClerk.Text;
                string key = txtRBClerk.Text.Substring(0, 4);
                string des = rbtxt.Substring(4);
                if (key == "PTN ")
                {
                    txtName.Text = des;
                    txtMRN.Text = GenerateMRN();
                    txtRBClerk.Text = "";
                }
                else if (key == "MRN ")
                {
                    txtMRN.Text = des;
                    txtRBClerk.Text = "";
                }

                else if (key == "CON ")
                {
                    txtContact.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "NIC ")
                {
                    txtNIC.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "ADR ")
                {
                    txtAddress.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "EML ")
                {
                    txtEmail.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "DOB ")
                {
                    txtDOB.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "GEN ")
                {
                    txtGen.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "BGP ")
                {
                    txtBlGp.Text = des;
                    txtRBClerk.Text = "";
                }

                else if (key == "OCC ")
                {
                    txtOccupation.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "DIS ")
                {
                    txtDistrict.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "ECN ")
                {
                    txtECN.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "PCP ")
                {
                    txtPCP.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "PFX ")
                {
                    txtPFX.Text = des;
                    txtRBClerk.Text = "";
                }
                else if (key == "SER ")
                {
                    Button4_Click(sender, e);
                    txtRBClerk.Text = "";
                }
                else if (key == "DEL ")
                {
                    btnDelete_Click(sender, e);
                    txtRBClerk.Text = "";
                }

            }
            if (txtRBClerk.Text.Length == 3)
            {
                string key2 = txtRBClerk.Text.Substring(0, 3);

                if (key2 == "CLR")
                {
                    txtRBClerk.Text = "";
                    btnClear_Click(sender, e);

                }
                else if (key2 == "ADD")
                {
                    txtRBClerk.Text = "";
                  
                    Button1_Click(sender, e);
                }

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Patient" + "(patient_id,NIC,name,address,TP,email,dob,gender,bloodgrp,occupation,district)values(@patient_id,@NIC,@name,@address,@TP,@email,@dob,@gender,@bloodgrp,@occupation,@district)", con);
            cmd1.Parameters.AddWithValue("@patient_id", txtMRN.Text);

            cmd1.Parameters.AddWithValue("@NIC", txtNIC.Text);
            cmd1.Parameters.AddWithValue("@name", txtName.Text);
            cmd1.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd1.Parameters.AddWithValue("@TP", txtContact.Text);
            cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd1.Parameters.AddWithValue("@dob", txtDOB.Text);
            cmd1.Parameters.AddWithValue("@gender", txtGen.Text);
            cmd1.Parameters.AddWithValue("@bloodgrp", txtBlGp.Text);
            cmd1.Parameters.AddWithValue("@occupation", txtOccupation.Text);
            cmd1.Parameters.AddWithValue("@district", txtDistrict.Text);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("Insert into PatientEmergencyDetails" + "(patient_id,primary_physician,pharmacy_fax_num,emergency_contact)values (@patient_id,@primary_physician,@pharmacy_fax_num,@emergency_contact)", con);
            cmd2.Parameters.AddWithValue("@patient_id", txtMRN.Text);
            cmd2.Parameters.AddWithValue("@primary_physician", txtPCP.Text);
            cmd2.Parameters.AddWithValue("@pharmacy_fax_num", txtPFX.Text);
            cmd2.Parameters.AddWithValue("@emergency_contact", txtECN.Text);
            cmd2.ExecuteNonQuery();
            con.Close();
            txtPFX.Text = "";
            txtPCP.Text = "";
            txtECN.Text = "";
            txtMRN.Text = "";
            txtNIC.Text = "";
            txtDOB.Text = "";
            txtBlGp.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDistrict.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtOccupation.Text = "";
            txtDistrict.Text = "";
            txtGen.Text = "";
        }



        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtMRN.Text = "";
            txtNIC.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            txtBlGp.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDistrict.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtOccupation.Text = "";
            txtDistrict.Text = "";
            txtGen.Text = "";
            txtPCP.Text = "";
            txtPFX.Text = "";
            txtECN.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("delete from Patient where patient_id=" + txtRBClerk.Text.Substring(4) + "", con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("delete from PatientEmergencyDetails where patient_id=" + txtRBClerk.Text.Substring(4) + "", con);
            cmd2.ExecuteNonQuery();
            txtMRN.Text = "";
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Patient where patient_id=" + txtRBClerk.Text.Substring(4) + "", con);
            cmd1.ExecuteNonQuery();
            SqlDataReader r1 = cmd1.ExecuteReader();
            while (r1.Read())
            {
                txtMRN.Text = r1[0].ToString();
                txtNIC.Text = r1[1].ToString();
                txtName.Text = r1[2].ToString();
                txtAddress.Text = r1[3].ToString();
                txtContact.Text = r1[4].ToString();
                txtEmail.Text = r1[5].ToString();
                txtDOB.Text = r1[6].ToString();
                txtGen.Text = r1[7].ToString();
                txtBlGp.Text = r1[8].ToString();
                txtOccupation.Text = r1[9].ToString();
                txtDistrict.Text = r1[10].ToString();

            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from PatientEmergencyDetails where patient_id=" + txtRBClerk.Text.Substring(4) + "", con);
            cmd2.ExecuteNonQuery();
            SqlDataReader r2 = cmd2.ExecuteReader();
            while (r2.Read())
            {
                txtPCP.Text = r2[1].ToString();
                txtPFX.Text = r2[2].ToString();
                txtECN.Text = r2[3].ToString();
            }
            con.Close();
        }
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Main.aspx");
        }
        private string GenerateMRN()
        {
            string mrn = "";
            using (SqlCommand cmd1 = new SqlCommand("Insert into Patient" + "(patient_id,NIC,name,address,TP,email,dob,gender,bloodgrp,occupation,district)values(@patient_id,@NIC,@name,@address,@TP,@email,@dob,@gender,@bloodgrp,@occupation,@district)", con))
            {
                SqlCommand cmd4 = new SqlCommand();
                cmd4.Connection = con;
                cmd4.CommandText = "SELECT MAX(patient_id) FROM Patient"; // get the highest patient ID
                con.Open();
                object result = cmd4.ExecuteScalar();
                int patientID = result == DBNull.Value ? 1 : Convert.ToInt32(result) + 1; // increment the highest patient ID by 1
                mrn = patientID.ToString();  // format the new MRN with leading zeros
            }
            return mrn;
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}







