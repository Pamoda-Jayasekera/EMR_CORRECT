
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace EMR
{
    public partial class LabReportDataEnter : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            txtRBox.Focus();

            

            txtDate.Text = DateTime.Now.ToString("M/dd/yyyy");
            if (Session["smrn"] != null)
            {
                string val = Session["smrn"].ToString();
                txtMRN.Text = val;
            }
            if (Session["sname"] != null)
            {
                string val1 = Session["sname"].ToString();
                txtPTN.Text = val1;
            }
        }

      

        protected void txtRBox_TextChanged(object sender, EventArgs e)
        {
            // Your event handling code here
      
            if (txtRBox.Text.Length > 4)
            {
                if (txtRBox.Text == "LOGOUT")
                {
                    txtRBox.Text = "";
                    btnLogOut_Click(sender, e);
                }
                string rbtxt = txtRBox.Text;
                string key = txtRBox.Text.Substring(0, 4);
                string des = rbtxt.Substring(4);
                if (key == "PTN ")
                {
                    txtPTN.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "MRN ")
                {
                    txtMRN.Text = des;
                    txtRBox.Text = "";
                }

                else if (key == "TPR ")
                {
                    txtTP.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "ALB ")
                {
                    txtAl.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "GLO ")
                {
                    txtGl.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "RAT ")
                {
                    txtRa.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "BIL")
                {
                    txtBi.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "PHO ")
                {
                    txtALK.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "ALT ")
                {
                    txtALT.Text = des;
                    txtRBox.Text = "";
                }

                else if (key == "AST ")
                {
                    txtAST.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "GAM ")
                {
                    txtGam.Text = des;
                    txtRBox.Text = "";
                }

                else if (key == "AGE ")
                {
                    txtAge.Text = des;
                    txtRBox.Text = "";
                }
                else if (key == "DCN")
                {
                    txtDocName.Text = des;
                    txtRBox.Text = "";
                }

                else if (key == "SER ")
                {
                    Button4_Click(sender, e);
                    txtRBox.Text = "";
                }

            }
            if (txtRBox.Text.Length == 3)
            {
                string key2 = txtRBox.Text.Substring(0, 3);

                if (key2 == "CLR")
                {
                    txtRBox.Text = "";
                    btnClear_Click(sender, e);

                }
                else if (key2 == "ADD")
                {
                    txtRBox.Text = "";

                    Button1_Click(sender, e);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTP.Text = "";
            txtAl.Text = "";
            txtGl.Text = "";
            txtRa.Text = "";
            txtBi.Text = "";
            txtALK.Text = "";
            txtALT.Text = "";
            txtAST.Text = "";
            txtGam.Text = "";
            txtPTN.Text = "";
            txtDocName.Text = "";
            txtAge.Text = "";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Main.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Lab_Liver_Test where patient_id=" + txtRBox.Text.Substring(4) + "", con);
            cmd1.ExecuteNonQuery();
            SqlDataReader r1 = cmd1.ExecuteReader();
            while (r1.Read())
            {
                txtMRN.Text = r1[0].ToString();
                txtTP.Text = r1[1].ToString();
                txtAl.Text = r1[2].ToString();
                txtGl.Text = r1[3].ToString();
                txtRa.Text = r1[4].ToString();
                txtBi.Text = r1[5].ToString();
                txtALK.Text = r1[6].ToString();
                txtALT.Text = r1[7].ToString();
                txtAST.Text = r1[8].ToString();
                txtGam.Text = r1[9].ToString();
                txtPTN.Text = r1[10].ToString();
                txtDocName.Text = r1[11].ToString();
                txtAge.Text = r1[12].ToString();


            }
            con.Close();
          
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Lab_Liver_Test (total_Protein,albumin,globulin,agRatio,bilirubin,phosphatase,alt,ast,gamma,name,age,doctor,patient_id)values(@total_Protein,@albumin,@globulin,@agRatio,@bilirubin,@phosphatase,@alt,@ast,@gamma,@name,@age,@doctor,@patient_id)", con);
            cmd1.Parameters.AddWithValue("@total_Protein", txtTP.Text);
            cmd1.Parameters.AddWithValue("@albumin", txtAl.Text);
            cmd1.Parameters.AddWithValue("@globulin", txtGl.Text);
            cmd1.Parameters.AddWithValue("@agRatio", txtRa.Text);
            cmd1.Parameters.AddWithValue("@bilirubin", txtBi.Text);
            cmd1.Parameters.AddWithValue("@phosphatase", txtALK.Text);
            cmd1.Parameters.AddWithValue("@alt", txtALT.Text);
            cmd1.Parameters.AddWithValue("@ast", txtAST.Text);
            cmd1.Parameters.AddWithValue("@gamma", txtGam.Text);
            cmd1.Parameters.AddWithValue("@name", txtPTN.Text);
            cmd1.Parameters.AddWithValue("@age", txtAge.Text); 
            cmd1.Parameters.AddWithValue("@doctor", txtDocName.Text); 
            cmd1.Parameters.AddWithValue("@patient_id", txtMRN.Text);

            cmd1.ExecuteNonQuery();

            con.Close();
            txtTP.Text = "";
            txtAl.Text = "";
            txtGl.Text = "";
            txtRa.Text = "";
            txtBi.Text = "";
            txtALK.Text = "";
            txtALT.Text = "";
            txtAST.Text = "";
            txtGam.Text = "";
           


        }




        protected void Button2_Click(object sender, EventArgs e)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from Patient where patient_id=" + txtRBox.Text.Substring(4) + "", con);
                cmd1.ExecuteNonQuery();
                SqlDataReader r1 = cmd1.ExecuteReader();
                while (r1.Read())
                {
                    txtMRN.Text = r1[0].ToString();
                    txtTP.Text = r1[1].ToString();
                    txtRa.Text = r1[2].ToString();

                }
                con.Close();

            }

        }
    }

           
        
    
