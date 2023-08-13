using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSEyes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtEyes.Text = "EYES: ";
            if (CheckBox1.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Dry eyes|";
            }
            if (CheckBox2.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Irritation|";
            }

            if (CheckBox3.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Corneas- ";
            }
            if (CheckBox5.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Abnormal mole|";
            }
            if (CheckBox6.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Juandice|";
            }
            if (CheckBox7.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Rash|";
            }
            if (CheckBox8.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Laceration|";
            }
            if (CheckBox7.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Iching|";
            }
            if (CheckBox8.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Dry skin|";
            }

            if (CheckBox11.Checked == true || CheckBox13.Checked == true || CheckBox15.Checked == true || CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true || CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Funduscopic- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Grossly normal|";
            }
            if (CheckBox13.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Normal vessels|";
            }
            if (CheckBox14.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Normal optic discs|";
            }
            if (CheckBox15.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Hemorrhages|";
            }
            if (CheckBox16.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Increased cupping|";
            }
            if (CheckBox17.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Paplledema|";
            }
            if (CheckBox18.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Narrowing or arteriols|";
            }
            if (CheckBox19.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "A-V nicking|";
            }
            if (CheckBox20.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Exudates|";
            }
            if (CheckBox21.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Soft exudates|";
            }
            if (CheckBox22.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Optic disk not well visualized|";
            }
            if (CheckBox23.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Hard exudates|";
            }
            if (CheckBox24.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Fundus not visualized, ";
            }
            if (CheckBox25.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Blurred margins|";
            }

            if (CheckBox26.Checked == true || CheckBox27.Checked == true || CheckBox28.Checked == true || CheckBox29.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " EOM- ";
            }
            if (CheckBox26.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "EOMI|";
            }
            if (CheckBox27.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Disconjugated|";
            }
            if (CheckBox28.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Strabismus|";
            }
            if (CheckBox29.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Nystagmus|";
            }

            if (CheckBox34.Checked == true || CheckBox35.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Lens- ";
            }
            if (CheckBox26.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Clear|";
            }
            if (CheckBox27.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Cataract|";
            }
            if (CheckBox36.Checked == true || CheckBox37.Checked == true || CheckBox38.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Sclera- ";
            }
            if (CheckBox36.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Injected|";
            }
            if (CheckBox37.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Icteric|";
            }
            if (CheckBox38.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Abrasion|";
            }
            if (CheckBox44.Checked == true || CheckBox45.Checked == true || CheckBox46.Checked == true || CheckBox47.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + " Vision- ";
            }
            if (CheckBox44.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Acuity and grossly intact|";
            }
            if (CheckBox45.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Field out|";
            }
            if (CheckBox46.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Prepheral vision grossly intact|";
            }
            if (CheckBox47.Checked == true)
            {
                txtEyes.Text = txtEyes.Text + "Acuity impaired|";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Eyes";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtEyes.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtEyes.Text = "";

        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
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
