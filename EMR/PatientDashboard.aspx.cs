using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection;

namespace EMR
{
    public partial class PatientDashboard : System.Web.UI.Page
    {
        public string lineData;
        public string lineDataBP;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            txtRBPatient.Focus();
            Session["hom"] = "PT";
            //new code change 
            if (Session["category"] != null && Session["category"].ToString() == "Patient")
            {
                MakeControlsReadOnly();
            }

            if (txtApCode.Text != "" && txtMRN.Text != "")
            {
                Session["smrn"] = txtMRN.Text;
                Session["sapc"] = txtApCode.Text;

                Allergy();
                PMH();
                FH();
                SH();
                ROS();
                addTextBoxCM();
                addTextBoxLab();
                Referrals();
                Assessment();
                SnapShot90Day();
                PI();

                LabReports();

                VC();
            }
            else
            {
                string val1 = Request.QueryString["apc"];
                string val2 = Request.QueryString["mrn"];
                txtApCode.Text = val1;
                txtMRN.Text = val2;
                if (txtApCode.Text != "" && txtMRN.Text != "")
                {
                    loadVitals();
                    PInfo();
                    PEmerDet();
                    Allergy();
                    PMH();
                    FH();
                    SH();
                    addTextBoxCM();
                    addTextBoxLab();
                    Referrals();
                    Assessment();
                    SnapShot90Day();
                    ROS();
                    PI();

                    LabReports();

                    VC();

                }
                if (txtDOB.Text != "")
                {
                    int yeartoday = DateTime.Now.Year;
                    int byear = int.Parse(txtDOB.Text.Substring(0, 4));
                    int yrs = yeartoday - byear;
                    txtAge.Text = yrs.ToString() + " yrs";
                }
            }




        }

        //new code change 
        private void MakeControlsReadOnly()
        {
            // Iterate over all controls and set them to read-only.
            // This is a recursive approach that disables all input controls on the page.
            DisableControls(this);
        }

        private void DisableControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // Exclude txtRBPatient and txtHOM from being made read-only or disabled
                if ((c is TextBox tb && tb.ID != "txtRBPatient" && tb.ID != "txtHOM") ||
                    (c is Button btn && btn.ID != "btnSpecificButtonToExclude") || // Replace with actual ID if there's a button to exclude
                    (c is DropDownList ddl && ddl.ID != "ddlSpecificDropDownToExclude")) // Replace with actual ID if there's a DropDownList to exclude
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).ReadOnly = true;
                    }
                    else if (c is Button)
                    {
                        ((Button)c).Enabled = false;
                    }
                    else if (c is DropDownList)
                    {
                        ((DropDownList)c).Enabled = false;
                    }
                    // ... include other control types as needed
                }

                // Recursive call for any container controls
                if (c.HasControls())
                {
                    DisableControls(c);
                }
            }
        }


        protected void VC()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT code, value FROM Medical_history WHERE patient_id = @patientId AND history_type = 'VC'", con);
                    cmd1.Parameters.AddWithValue("@patientId", txtMRN.Text);

                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    // Bind the data to CheckBoxList8
                    CheckBoxList8.DataTextField = "value";
                    CheckBoxList8.DataSource = dt1;
                    CheckBoxList8.DataBind();

                    // Commenting out the loop for CheckBoxList6 as it seems unrelated
                    // for (int i = 0; i < CheckBoxList6.Items.Count; i++)
                    // {
                    //     CheckBoxList6.Items[i].Selected = true;
                    // }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and provide error messages
                // For example: Response.Write("Error: " + ex.Message);
            }
        }








        protected void PMH()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Medical_history where patient_id=" + txtMRN.Text + " and history_type='PMH' ", con);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CheckBoxList2.DataTextField = "code";

            CheckBoxList2.DataSource = dt1;
            CheckBoxList2.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                CheckBoxList2.Items[i].Selected = true;
            }
        }
        protected void Allergy()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct code,note from Medical_history where patient_id=" + txtMRN.Text + " and history_type='ALL'", con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList1.DataTextField = "note";
            CheckBoxList1.DataSource = dt2;
            CheckBoxList1.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                CheckBoxList1.Items[i].Selected = true;
            }

        }
        protected void Referrals()
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct speciality from Referrals where patient_id=" + txtMRN.Text, con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList6.DataTextField = "speciality";
            CheckBoxList6.DataSource = dt2;
            CheckBoxList6.DataBind();
            dt2.Clear();
            con.Close();
            for (int i = 0; i < CheckBoxList6.Items.Count; i++)
            {
                CheckBoxList6.Items[i].Selected = true;
            }

        }
        public void addTextBoxCM()
        {
            con.Open();
            TextBox txt1 = new TextBox();
            txt1.TextMode = TextBoxMode.MultiLine;
            txt1.Width = 340;
            txt1.BorderWidth = 0;
            txt1.Font.Bold = true;
            txt1.Attributes.Add("style", "overflow :hidden");
            txt1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from [Order] where patient_id=" + txtMRN.Text + " and type='Med'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt1.Rows = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt1.Text += dt.Rows[i].ItemArray[2].ToString() + "\n";

            }
            dt.Clear();
            con.Close();
            if (txt1.Text != "")
            {
                addControl1.Controls.Add(txt1);
            }

        }
        public void LabReports()
        {
            con.Open();
            TextBox txt1 = new TextBox();
            txt1.TextMode = TextBoxMode.MultiLine;
            txt1.Width = 100;
            txt1.BorderWidth = 0;
            txt1.Font.Bold = true;
            txt1.Style["text-align"] = "center";
            txt1.Attributes.Add("style", "overflow :hidden");
            txt1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Images where patient_id=" + txtMRN.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt1.Rows = 2;
            txt1.Text = dt.Rows.Count.ToString() + "   Images";
            dt.Clear();
            con.Close();
            addControlLab.Controls.Add(txt1);
        }

        public void addTextBoxLab()
        {
            con.Open();
            TextBox txt2 = new TextBox();
            txt2.TextMode = TextBoxMode.MultiLine;
            txt2.Width = 160;
            txt2.BorderWidth = 0;
            txt2.Font.Bold = true;
            txt2.Attributes.Add("style", "overflow :hidden");
            txt2.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from [Order] where patient_id=" + txtMRN.Text + " and type='Lab'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt2.Rows = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                txt2.Text += dt.Rows[i].ItemArray[2].ToString() + "\n";

            }
            dt.Clear();
          //  addControl10.Controls.Add(txt2);
            con.Close();
        }
        public void Assessment()
        {
            con.Open();
            TextBox txt2 = new TextBox();
            txt2.TextMode = TextBoxMode.MultiLine;
            txt2.Width = 120;
            txt2.BorderWidth = 0;
            txt2.Font.Bold = true;
            txt2.Attributes.Add("style", "overflow :hidden");

            txt2.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select Distinct convert(nvarchar(10), datestamp, 120),patient_id from Assessment where patient_id=" + txtMRN.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt2.Rows = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt2.Text += dt.Rows[i].ItemArray[0].ToString() + "\n";
            }
            dt.Clear();
            addControl2.Controls.Add(txt2);
            con.Close();


        }
        public void SnapShot90Day()
        {
            con.Open();
            TextBox txt3 = new TextBox();
            txt3.TextMode = TextBoxMode.MultiLine;
            txt3.Width = 100;
            txt3.BorderWidth = 0;
            txt3.Font.Bold = true;
            txt3.Style["text-align"] = "center";
            txt3.Attributes.Add("style", "overflow :hidden");
            txt3.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select Distinct convert(nvarchar(10), datestamp, 120),patient_id from Assessment where patient_id=" + txtMRN.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt3.Rows = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                txt3.Text += dt.Rows[i].ItemArray[0].ToString() + "\n";

            }
            dt.Clear();
            addControl3.Controls.Add(txt3);
            con.Close();


        }
        protected void FH()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct code from Medical_history where patient_id=" + txtMRN.Text + " and history_type='FH'", con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList3.DataTextField = "code";

            CheckBoxList3.DataSource = dt2;
            CheckBoxList3.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList3.Items.Count; i++)
            {
                CheckBoxList3.Items[i].Selected = true;
            }

        }
        protected void PI()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct symptom from PresentIllness where app_code=" + txtApCode.Text, con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList5.DataTextField = "symptom";

            CheckBoxList5.DataSource = dt2;
            CheckBoxList5.DataBind();
            dt2.Clear();
            con.Close();
            for (int i = 0; i < CheckBoxList5.Items.Count; i++)
            {
                CheckBoxList5.Items[i].Selected = true;
            }

        }
        protected void SH()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select distinct code,value from Medical_history where patient_id=" + txtMRN.Text + " and history_type='SH' ", con);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CheckBoxList4.DataTextField = "value";

            CheckBoxList4.DataSource = dt1;
            CheckBoxList4.DataBind();
            dt1.Clear();
            con.Close();
            for (int i = 0; i < CheckBoxList4.Items.Count; i++)
            {
                CheckBoxList4.Items[i].Selected = true;
            }
        }
        protected void ROS()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select distinct review_type from Review_of_System where patient_id=" + txtMRN.Text + " ", con);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CheckBoxList7.DataTextField = "review_type";
            CheckBoxList7.DataSource = dt1;
            CheckBoxList7.DataBind();
            dt1.Clear();
            con.Close();
            for (int i = 0; i < CheckBoxList7.Items.Count; i++)
            {
                CheckBoxList7.Items[i].Selected = true;
            }
        }
        protected void txtRBPatient_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtRBPatient.Text.Length > 4)
                {
                    if (txtRBPatient.Text == "LOGOUT")
                    {
                        txtRBPatient.Text = "";
                        btnLogOut_Click(sender, e);
                    }
                    string rbtxt = txtRBPatient.Text;
                    string key = txtRBPatient.Text.Substring(0, 4);
                    string des = rbtxt.Substring(4);

                    if (key == "APC ")
                    {
                        txtApCode.Text = des;
                        txtRBPatient.Text = "";
                    }
                    if (key == "MRN ")
                    {
                        txtMRN.Text = des;
                        txtRBPatient.Text = "";
                    }

                    else if (key == "VID ")
                    {
                        txtVID.Text = des;
                        txtRBPatient.Text = "";
                    }
                }
                if (txtRBPatient.Text.Length == 3)
                {
                    string key2 = txtRBPatient.Text.Substring(0, 3);
                    if (key2 == "PMH")
                    {
                        Response.Redirect("PastMedicalHistory.aspx?mode=view");
                    }

                    else if (key2 == "ALL")
                    {
                        Response.Redirect("Allergy.aspx?mode=view");
                    }
                    else if (key2 == "IMG")
                    {
                        Response.Redirect("Image.aspx?mode=view");
                    }
                    else if (key2 == "ROS")
                    {
                        Response.Redirect("ReviewofSystem.aspx?mode=view");
                    }
                    else if (key2 == "ASS")
                    {
                        Response.Redirect("Assessment.aspx?mode=view");
                    }
                    else if (key2 == "ORD")
                    {
                        Response.Redirect("Orders.aspx?mode=view");
                    }
                  
                    else if (key2 == "REF")
                    {
                        Response.Redirect("Referrals.aspx?mode=view");
                    }
                    else if (key2 == "CLR")
                    {
                        btnClear_Click(sender, e);
                    }


                }
                if (txtRBPatient.Text.Length == 4)
                {
                    string key4 = txtRBPatient.Text.Substring(0, 4);
                    if (key4 == "PTED")
                    {
                        Response.Redirect("PatientEducation.aspx?mode=view");
                    }
                }
                if (txtRBPatient.Text.Length == 5)
                {
                    string key4 = txtRBPatient.Text.Substring(0, 5);
                    if (key4 == "FOLUP")
                    {
                        Response.Redirect("FollowUps.aspx?mode=view");
                    }
                    else if (key4 == "90DAY")
                    {
                        Response.Redirect("90DaySnap.aspx?mode=view");
                    }

                }
                if (txtRBPatient.Text.Length == 2)
                {
                    string key1 = txtRBPatient.Text.Substring(0, 2);

                    if (key1 == "FH")
                    {
                        Response.Redirect("FamilyHistory.aspx?mode=view");
                    }
                    else if (key1 == "CM")
                    {
                        Response.Redirect("CurrentMedications.aspx?mode=view");
                    }
                    else if (key1 == "PI")
                    {
                        Response.Redirect("PresentIllness.aspx?mode=view");
                    }
                    else if (key1 == "SH")
                    {
                        Response.Redirect("SocialHistory.aspx?mode=view");
                    }
                    else if (key1 == "LR")
                    {
                        Response.Redirect("MALabReport.aspx?mode=view");
                    }

                    else if (key1 == "VC")
                    {
                        Response.Redirect("Vaccination.aspx?mode=view");
                    }
                }

                loadVitals();
                if (txtMRN.Text != "")
                {
                    PInfo();
                    PEmerDet();
                    Allergy();
                    PMH();
                    FH();
                    ROS();
                    SH();
                    PI();
                    addTextBoxCM();
                    addTextBoxLab();
                    Referrals();
                    Assessment();
                    SnapShot90Day();

                    LabReports();

                    VC();
                }
                if (txtDOB.Text != "")
                {
                    int yeartoday = DateTime.Now.Year;
                    int byear = int.Parse(txtDOB.Text.Substring(0, 4));
                    int yrs = yeartoday - byear;
                    txtAge.Text = yrs.ToString() + " yrs";
                }

            }
            catch (Exception ex)
            {

            }
        }
        protected void PEmerDet()
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from PatientEmergencyDetails where patient_id=" + txtMRN.Text + "", con);
            cmd3.ExecuteNonQuery();
            SqlDataReader r3 = cmd3.ExecuteReader();
            while (r3.Read())
            {
                txtPCP.Text = r3[1].ToString();
                txtPFX.Text = r3[2].ToString();
                txtECN.Text = r3[3].ToString();
            }
            con.Close();
        }
        protected void PInfo()
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Patient where patient_id=" + txtMRN.Text + "", con);
            cmd2.ExecuteNonQuery();
            SqlDataReader r2 = cmd2.ExecuteReader();
            while (r2.Read())
            {

                txtPTN.Text = r2[2].ToString();
                txtContact.Text = r2[4].ToString();
                txtEmail.Text = r2[5].ToString();
                txtDOB.Text = r2[6].ToString();
                txtGen.Text = r2[7].ToString();
                txtBGP.Text = r2[8].ToString();
                txtDistrict.Text = r2[10].ToString();
            }
            con.Close();
        }
        protected void loadVitals()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Vitals where app_code=" + txtApCode.Text + "", con);

            cmd1.ExecuteNonQuery();
            SqlDataReader r1 = cmd1.ExecuteReader();
            while (r1.Read())
            {
                txtVID.Text = r1[0].ToString();
                txtBP.Text = r1[2].ToString();
                txtWei.Text = r1[3].ToString();
                txtHei.Text = r1[4].ToString();
                txtPulse.Text = r1[5].ToString();
                txtTemp.Text = r1[6].ToString();
                txtPO2.Text = r1[7].ToString();
                txtMRN.Text = r1[8].ToString();
                txtBMI.Text = r1[10].ToString();

                if (double.TryParse(txtBMI.Text, out double bmi))
                {
                    if (bmi < 18.5 || bmi > 24.9)
                    {
                        txtBMI.Style["color"] = "red";
                    }
                    else
                    {
                        txtBMI.Style["color"] = "black"; // Or any default color
                    }
                }

                // Check Temperature value
                if (double.TryParse(txtTemp.Text, out double temp))
                {
                    if (temp < 36.1 || temp > 37.2)
                    {
                        txtTemp.Style["color"] = "red";
                    }
                    else
                    {
                        txtTemp.Style["color"] = "black"; // Or any default color
                    }
                }

                // Check Pulse value
                if (int.TryParse(txtPulse.Text, out int pulse))
                {
                    if (pulse < 60 || pulse > 100)
                    {
                        txtPulse.Style["color"] = "red";
                    }
                    else
                    {
                        txtPulse.Style["color"] = "black"; // Or any default color
                    }
                }
            }
            con.Close();
        }





        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            var nvc = HttpUtility.ParseQueryString(Request.Url.Query);
            nvc.Remove("mrn");
            nvc.Remove("apc");
            string url = Request.Url.AbsolutePath + "?" + nvc.ToString();
            Response.Redirect(url);
            txtApCode.Text = "";
            txtBGP.Text = "";
            txtBMI.Text = "";
            txtBP.Text = "";
            txtContact.Text = "";
            txtDOB.Text = "";
            txtEmail.Text = "";
            txtGen.Text = "";
            txtHei.Text = "";
            txtMRN.Text = "";
            txtPO2.Text = "";
            txtPTN.Text = "";
            txtPulse.Text = "";
            txtTemp.Text = "";
            txtVID.Text = "";
            txtDistrict.Text = "";
            txtWei.Text = "";
            txtAge.Text = "";
            txtECN.Text = "";
            txtPFX.Text = "";
            txtPCP.Text = "";
            CheckBoxList1.Items.Clear();
            CheckBoxList2.Items.Clear();
            CheckBoxList3.Items.Clear();
            CheckBoxList4.Items.Clear();
            CheckBoxList5.Items.Clear();
            CheckBoxList6.Items.Clear();
            CheckBoxList7.Items.Clear();
            addControl1.Controls.Clear();
            addControl2.Controls.Clear();
            addControl3.Controls.Clear();
            //addControl10.Controls.Clear();
            addControlLab.Controls.Clear();

            Session.Clear();

        }



        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Main.aspx");
        }
    }
}
