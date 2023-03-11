using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class VisionProblem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAbdom.Text = "VISION PROBLEM: ";
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox4.Checked == true || CheckBox14.Checked == true || CheckBox24.Checked == true || CheckBox22.Checked == true
            || CheckBox16.Checked == true || CheckBox13.Checked == true || CheckBox23.Checked == true || CheckBox26.Checked == true || CheckBox27.Checked == true || CheckBox25.Checked == true
            || CheckBox30.Checked == true || CheckBox28.Checked == true || CheckBox29.Checked == true || CheckBox34.Checked == true || CheckBox38.Checked == true || CheckBox39.Checked == true
            || CheckBox31.Checked == true || CheckBox33.Checked == true || CheckBox32.Checked == true || CheckBox40.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Vision problem is- ";
            }
            if (CheckBox1.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blurry distant objects | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blurry nearby objects | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blurry or blind spot in center of vision | ";
            }
            if (CheckBox14.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Bright zigzag lines | ";
            }
            if (CheckBox24.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Flashes of light | ";
            }
            if (CheckBox22.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Double vision | ";
            }
            if (CheckBox16.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Clouded, hazy or dim vision | ";
            }
            if (CheckBox13.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Blurry vision at all distances | ";
            }
            if (CheckBox23.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Fading of colors | ";
            }
            if (CheckBox26.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Halos around lights | ";
            }
            if (CheckBox27.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Inability to distinguish certain shades of color | ";
            }
            if (CheckBox25.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Glare with bright lights | ";
            }
            if (CheckBox30.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Poor night vision | ";
            }
            if (CheckBox28.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Loss of side vision | ";
            }
            if (CheckBox29.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Objects appear crooked or distorted | ";
            }
            if (CheckBox34.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Shimmering spots or stars | ";
            }
            if (CheckBox38.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Spots or strings floating in field of vision | ";
            }
            if (CheckBox39.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Tunnel vision | ";
            }
            if (CheckBox31.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Progressive expansion of shadow or curtain over visual field | ";
            }
            if (CheckBox33.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Sensitivity to light | ";
            }
            if (CheckBox32.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Seeing nonexistent things, or hallucinating | ";
            }
            if (CheckBox40.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Vision loss, partial or total | ";
            }
            if (CheckBox11.Checked == true || CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Problem affects- ";
            }
            if (CheckBox11.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Both eyes | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "One eye | ";
            }
            if (CheckBox3.Checked == true || CheckBox6.Checked == true || CheckBox35.Checked == true || CheckBox36.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Vision improves somewhat with- ";
            }
            if (CheckBox3.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Holding objects away from face | ";
            }
            if (CheckBox6.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Holding objects close to face | ";
            }
            if (CheckBox35.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Squinting | ";
            }
            if (CheckBox36.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Use of bright lighting | ";
            }
            if (CheckBox37.Checked == true || CheckBox41.Checked == true || CheckBox46.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + " Onset is- ";
            }
            if (CheckBox37.Checked == true)
            {
                txtAbdom.Text = txtAbdom.Text + "Gradual or progressive | ";
            }
                if (CheckBox41.Checked == true)
                {
                    txtAbdom.Text = txtAbdom.Text + "Recent (hours to days) | ";
                }
                if (CheckBox46.Checked == true)
                {
                    txtAbdom.Text = txtAbdom.Text + " Sudden (seconds to minutes),";
                }
                if (CheckBox42.Checked == true || CheckBox41.Checked == true || CheckBox46.Checked == true)
                {
                    txtAbdom.Text = txtAbdom.Text + " Duration is- ";
                }
                if (CheckBox42.Checked == true)
                {
                    txtAbdom.Text = txtAbdom.Text + "A few minutes | ";
                }
                    if (CheckBox43.Checked == true)
                    {
                        txtAbdom.Text = txtAbdom.Text + "Usually no longer than 30 minute | ";
                    }
                    if (CheckBox46.Checked == true)
                    {
                        txtAbdom.Text = txtAbdom.Text + " Sudden (seconds to minutes) | ";
                    }
                    if (CheckBox42.Checked == true || CheckBox41.Checked == true || CheckBox46.Checked == true)
                    {
                        txtAbdom.Text = txtAbdom.Text + " Duration is- ";
                    }
                    if (CheckBox42.Checked == true)
                    {
                        txtAbdom.Text = txtAbdom.Text + "A few minutes | ";
                    }
                        if (CheckBox43.Checked == true)
                        {
                            txtAbdom.Text = txtAbdom.Text + "Usually no longer than 30 minute | ";
                        }
                        if (CheckBox46.Checked == true)
                        {
                            txtAbdom.Text = txtAbdom.Text + " Sudden (seconds to minutes) | ";
                        }
                        if (CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox15.Checked == true || CheckBox19.Checked == true
                        || CheckBox12.Checked == true || CheckBox17.Checked == true || CheckBox18.Checked == true)
                        {
                            txtAbdom.Text = txtAbdom.Text + " Accompanied by- ";
                        }
                        if (CheckBox7.Checked == true)
                        {
                            txtAbdom.Text = txtAbdom.Text + "Confusion or trouble talking | ";
                        }
                            if (CheckBox8.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + "Dizziness or difficulty walking | ";
                            }
                            if (CheckBox9.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Eye pain or discomfort | ";
                            }
                            if (CheckBox10.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Eye redness | ";
                            }
                            if (CheckBox15.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Eyestrain | ";
                            }
                            if (CheckBox19.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Headache | ";
                            }
                            if (CheckBox12.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Numbness or weakness on one side of the body | ";
                            }
                            if (CheckBox17.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + " Other sensory disturbances | ";
                            }
                            if (CheckBox18.Checked == true)
                            {
                                txtAbdom.Text = txtAbdom.Text + "  Swelling around the eye | ";
                            }
                        
                    
                }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Vision Problem";

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
         
            