using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class KneePain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "KNEE PAIN: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Pain is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Dull or achy | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gradually worsening | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Persistent | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sharp or severe | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sudden | ";
            }
            if (CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Located- ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Long one or both sides of the knee | ";
            }
            if (CheckBox7.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Around the kneecap | ";
            }
            if (CheckBox8.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Behind the knee | ";
            }
            if (CheckBox9.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "In the knee joint | ";
            }
            if (CheckBox10.Checked == true || CheckBox11.Checked == true || CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Trigged by- ";
            }
            if (CheckBox10.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Everyday activities | ";
            }

            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Injury | ";
            }
            if (CheckBox12.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Overuse | ";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true || CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Worsened by- ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Movement | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Prolonged sitting or standing | ";
            }
            if (CheckBox15.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Rest or inactivity | ";
            }
            if (CheckBox16.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true || CheckBox19.Checked == true || CheckBox20.Checked == true || CheckBox21.Checked == true || CheckBox22.Checked == true || CheckBox23.Checked == true || CheckBox24.Checked == true || CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bruising or discoloring | ";
            }
            if (CheckBox17.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Decreased range of motion | ";
            }
            if (CheckBox18.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Feeling of instability | ";
            }
            if (CheckBox19.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Inability to bear weight | ";
            }
            if (CheckBox20.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Joint weakness | ";
            }

            if (CheckBox21.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Grating sensation | ";
            }

            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Skin redness | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Locking or catching | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Popping or snapping | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Swelling | ";
            }

            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Warmth to touch | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Stiffness | ";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Knee Pain";

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