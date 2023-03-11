using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EMR
{
    public partial class Headache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "HEADACHES: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true || CheckBox5.Checked == true || CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Pain is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Extreme | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Mild to moderate | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Moderate to severe | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Pressure or squeezing sensation | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stabbing or burning | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Throbing | ";
            }
            if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Pain located in- ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Around one eye or radiates from one eye | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Around your temples | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "On both sides of your head | ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "On one side of your head | ";
            }
            if (CheckBox11.Checked == true || CheckBox12.Checked == true || CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Onset is- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gradual | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Preceded by frequent use of pain medication | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Preceded by head injury or fall | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Preceded by visual or other sensory disturbances | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sudden | ";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Duration is- ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "A few hours to days | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "A few minutes to hours | ";
            }
            if (CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Recurrence of headache- ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gradually becomes more frequent | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Is daily | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Is often the same time everyday | ";
            }
            if (CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox27.Checked == true || CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Trigged or worsened by- ";
            }
            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in sleep patterns | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Chewing | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Clenching or grinding teeth | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Everyday activities | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Hormonal changes | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Orgasm | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Poor posture | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stress | ";
            }
            if (CheckBox29.Checked == true || CheckBox30.Checked == true || CheckBox31.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Relieved by- ";
            }
            if (CheckBox29.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Lying down in the dark | ";
            }
            if (CheckBox30.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Over-the-counter pain medication | ";
            }
            if (CheckBox31.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Rest | ";
            }
            if (CheckBox32.Checked == true || CheckBox33.Checked == true || CheckBox34.Checked == true || CheckBox35.Checked == true || CheckBox36.Checked == true || CheckBox37.Checked == true || CheckBox38.Checked == true || CheckBox39.Checked == true || CheckBox40.Checked == true || CheckBox41.Checked == true || CheckBox42.Checked == true || CheckBox43.Checked == true || CheckBox44.Checked == true || CheckBox45.Checked == true || CheckBox46.Checked == true || CheckBox47.Checked == true || CheckBox48.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox32.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Change in personality, behaviors or mental status | ";
            }
            if (CheckBox33.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Confusion | ";
            }
            if (CheckBox34.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Difficulty speaking | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dizziness | ";
            }
            if (CheckBox36.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fever | ";
            }
            if (CheckBox37.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Jaw pain | ";
            }
            if (CheckBox38.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Memory loss or forgetfulness | ";
            }
            if (CheckBox39.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Muscle or joint aches | ";
            }
            if (CheckBox40.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Nausea or vomiting | ";
            }
            if (CheckBox41.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Persistent weakness or numbness | ";
            }
            if (CheckBox42.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Restlessness or agitation | ";
            }
            if (CheckBox43.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Runny or stuffy nose | ";
            }
            if (CheckBox44.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Seizures | ";
            }
            if (CheckBox45.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sensitivity to light or noise | ";
            }
            if (CheckBox46.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stiff neck | ";
            }
            if (CheckBox47.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Tender scalp | ";
            }
            if (CheckBox48.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Vision problems | ";
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Headache";

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

        protected void txtAbdom_TextChanged(object sender, EventArgs e)
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