using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class NauseaorVomitting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "NAUSEA OR VOMITTING: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Trigged or worsened by- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Drinking Alcohol | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Eating certain foods | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stress | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Traval or motion | ";
            }


            if (CheckBox11.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Onset is- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Intermitted or episodic | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Recent(hours to days) | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sudden(minutes to hours) | ";
            }


            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox15.Checked == true || CheckBox19.Checked == true || CheckBox10.Checked == true
           || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox16.Checked == true || CheckBox14.Checked == true ||
           CheckBox20.Checked == true || CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox24.Checked == true || CheckBox28.Checked == true || CheckBox26.Checked == true
          || CheckBox25.Checked == true || CheckBox23.Checked == true || CheckBox29.Checked == true || CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " ACCOMPANIED BY- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Abdominal bloating or swelling | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dizziness or fainting | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Abdominal pain, discomfort or cramps | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Anxiety | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Feeling of fullness after eating small amounts of food | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Black or bloody stools | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Headache | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Chest pain or tightness | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Irregular or rapid heartbeat | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Heartburn | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in urination habits | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Confusion | ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Passing gas | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Constipation,";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dark urine | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficulty breathing | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Diarrhea | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "sweating | ";
            }

            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Skin itching | ";
            }
            if (CheckBox29.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Unintended weight loss | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Swelling of feet and ankles | ";
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Nausea or Vomitting";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into PresentIllness" + "(patient_id,app_code,symptom,note,datestamp)values(@patient_id1,@app_code1,@symptom1,@note1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@app_code1", apc);
            cmd1.Parameters.AddWithValue("@symptom1", symp);
            string des = txtAbdom.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.ExecuteNonQuery();
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "ADD")
            {
                btnSubmit_Click(sender, e);
                btnAdd_Click(sender, e);
            }

            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("~/PresentIllness.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}