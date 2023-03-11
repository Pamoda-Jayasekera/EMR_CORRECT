using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class ROSAll : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("ReviewofSystem.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            TextBox1.Text = "General: ";
            if (CheckBox1.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "Weight loss or gain | ";
            }
            if (CheckBox2.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "Fever or chills | ";
            }
            if (CheckBox4.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "Trouble sleeping | ";
            }
            if (CheckBox3.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "Fatigue | ";
            }
            if (CheckBox5.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "Weakness | ";
            }
            if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true || CheckBox4.Checked == true || CheckBox5.Checked == true)
            {
                string symp = "General";
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd1.Parameters.AddWithValue("@patient_id1", mrn);
                cmd1.Parameters.AddWithValue("@code1", apc);
                cmd1.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox1.Text;
                cmd1.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd1.Parameters.AddWithValue("@datestamp1", d);
                cmd1.Parameters.AddWithValue("@review_type1", symp);
                cmd1.ExecuteNonQuery();
                con.Close();
                TextBox1.Text = "";
            }

            TextBox2.Text = "Skin: ";
            if (CheckBox6.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Rashes | ";
            }
            if (CheckBox7.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Itching | ";
            }

            if (CheckBox8.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Color changes | ";
            }
            if (CheckBox9.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Lumps | ";
            }
            if (CheckBox10.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Dryness | ";
            }
            if (CheckBox11.Checked == true)
            {
                TextBox2.Text = TextBox2.Text + "Hair and nail changes | ";
            }
            if (CheckBox6.Checked == true || CheckBox7.Checked == true || CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox11.Checked == true)
            {
                string symp = "Skin";
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd2.Parameters.AddWithValue("@patient_id1", mrn);
                cmd2.Parameters.AddWithValue("@code1", apc);
                cmd2.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox2.Text;
                cmd2.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd2.Parameters.AddWithValue("@datestamp1", d);
                cmd2.Parameters.AddWithValue("@review_type1", symp);
                cmd2.ExecuteNonQuery();
                con.Close();
                TextBox2.Text = "";
            }


            TextBox3.Text = "Head: ";
            if (CheckBox13.Checked == true)
            {
                TextBox3.Text = TextBox3.Text + "Headache | ";
            }
            if (CheckBox14.Checked == true)
            {
                TextBox3.Text = TextBox3.Text + "Head injury | ";
            }
            if (CheckBox13.Checked == true || CheckBox14.Checked == true)
            {
                string symp = "Head";
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd3.Parameters.AddWithValue("@patient_id1", mrn);
                cmd3.Parameters.AddWithValue("@code1", apc);
                cmd3.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox3.Text;
                cmd3.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd3.Parameters.AddWithValue("@datestamp1", d);
                cmd3.Parameters.AddWithValue("@review_type1", symp);
                cmd3.ExecuteNonQuery();
                con.Close();
                TextBox3.Text = "";
            }




            TextBox4.Text = "Ears: ";
            if (CheckBox19.Checked == true)
            {
                TextBox4.Text = TextBox4.Text + "Decreased hearing | ";
            }
            if (CheckBox20.Checked == true)
            {
                TextBox4.Text = TextBox4.Text + "Earache | ";
            }

            if (CheckBox21.Checked == true)
            {
                TextBox4.Text = TextBox4.Text + "Ringing in ears(tinnitus) | ";
            }
            if (CheckBox22.Checked == true)
            {
                TextBox4.Text = TextBox4.Text + "Dtainage | ";
            }
            if (CheckBox19.Checked == true || CheckBox20.Checked == true || CheckBox21.Checked == true || CheckBox22.Checked == true)
            {
                string symp = "Ears";
                con.Open();
                SqlCommand cmd4 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd4.Parameters.AddWithValue("@patient_id1", mrn);
                cmd4.Parameters.AddWithValue("@code1", apc);
                cmd4.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox4.Text;
                cmd4.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd4.Parameters.AddWithValue("@datestamp1", d);
                cmd4.Parameters.AddWithValue("@review_type1", symp);
                cmd4.ExecuteNonQuery();
                con.Close();
                TextBox4.Text = "";
            }


            TextBox5.Text = "Eyes: ";
            if (CheckBox25.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Vision | ";
            }
            if (CheckBox26.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Glasses or contacts | ";
            }

            if (CheckBox27.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Pain | ";
            }
            if (CheckBox28.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Redness | ";
            }
            if (CheckBox31.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Blurry or double vision | ";
            }
            if (CheckBox32.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Cataracts | ";
            }

            if (CheckBox33.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Flashing lights | ";
            }
            if (CheckBox34.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Last eye exam | ";
            }
            if (CheckBox35.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Specks | ";
            }

            if (CheckBox29.Checked == true)
            {
                TextBox5.Text = TextBox5.Text + "Glucoma | ";
            }

            if (CheckBox25.Checked == true || CheckBox26.Checked == true || CheckBox27.Checked == true || CheckBox28.Checked == true || CheckBox31.Checked == true || CheckBox32.Checked == true
             || CheckBox33.Checked == true || CheckBox34.Checked == true || CheckBox35.Checked == true || CheckBox29.Checked == true)
            {
                string symp = "Eyes";
                con.Open();
                SqlCommand cmd5 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd5.Parameters.AddWithValue("@patient_id1", mrn);
                cmd5.Parameters.AddWithValue("@code1", apc);
                cmd5.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox5.Text;
                cmd5.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd5.Parameters.AddWithValue("@datestamp1", d);
                cmd5.Parameters.AddWithValue("@review_type1", symp);
                cmd5.ExecuteNonQuery();
                con.Close();
                TextBox5.Text = "";
            }

            TextBox6.Text = "Nose: ";
            if (CheckBox30.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "stuffiness | ";
            }
            if (CheckBox36.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "Nosebleeds | ";
            }

            if (CheckBox37.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "Hay fever | ";
            }

            if (CheckBox123.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "Itching | ";
            }
            if (CheckBox126.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "discharge | ";
            }

            if (CheckBox130.Checked == true)
            {
                TextBox6.Text = TextBox6.Text + "Sinus pain | ";
            }
            if (CheckBox30.Checked == true || CheckBox36.Checked == true || CheckBox37.Checked == true || CheckBox123.Checked == true || CheckBox126.Checked == true || CheckBox130.Checked == true)
            {
                string symp = "Nose";
                con.Open();
                SqlCommand cmd6 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd6.Parameters.AddWithValue("@patient_id1", mrn);
                cmd6.Parameters.AddWithValue("@code1", apc);
                cmd6.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox6.Text;
                cmd6.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd6.Parameters.AddWithValue("@datestamp1", d);
                cmd6.Parameters.AddWithValue("@review_type1", symp);
                cmd6.ExecuteNonQuery();
                con.Close();
                TextBox6.Text = "";
            }

            TextBox7.Text = "Neck: ";
            if (CheckBox49.Checked == true)
            {
                TextBox7.Text = TextBox7.Text + "Lumps | ";
            }
            if (CheckBox50.Checked == true)
            {
                TextBox7.Text = TextBox7.Text + "Swollen glands | ";
            }

            if (CheckBox132.Checked == true)
            {
                TextBox7.Text = TextBox7.Text + "Pain | ";
            }
            if (CheckBox133.Checked == true)
            {
                TextBox7.Text = TextBox7.Text + "Stiffness | ";
            }
            if (CheckBox49.Checked == true || CheckBox50.Checked == true || CheckBox132.Checked == true || CheckBox133.Checked == true)
            {
                string symp = "Neck";
                con.Open();
                SqlCommand cmd7 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd7.Parameters.AddWithValue("@patient_id1", mrn);
                cmd7.Parameters.AddWithValue("@code1", apc);
                cmd7.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox7.Text;
                cmd7.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd7.Parameters.AddWithValue("@datestamp1", d);
                cmd7.Parameters.AddWithValue("@review_type1", symp);
                cmd7.ExecuteNonQuery();
                con.Close();
                TextBox7.Text = "";
            }

            TextBox8.Text = "Throat: ";
            if (CheckBox39.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Teeth | ";
            }
            if (CheckBox42.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Gums | ";
            }

            if (CheckBox45.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Bleeeding | ";
            }
            if (CheckBox47.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Dentures | ";
            }
            if (CheckBox40.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Sore tongue | ";
            }
            if (CheckBox43.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Dry mouth | ";
            }

            if (CheckBox46.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Sore throat | ";
            }
            if (CheckBox48.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Horesness | ";
            }
            if (CheckBox41.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Thrush | ";
            }
            if (CheckBox44.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Non healing sores | ";
            }

            if (CheckBox53.Checked == true)
            {
                TextBox8.Text = TextBox8.Text + "Last dental exam | ";
            }
            if (CheckBox39.Checked == true || CheckBox42.Checked == true || CheckBox45.Checked == true || CheckBox47.Checked == true || CheckBox40.Checked == true || CheckBox43.Checked == true
              || CheckBox46.Checked == true || CheckBox48.Checked == true || CheckBox41.Checked == true || CheckBox44.Checked == true || CheckBox53.Checked == true)
            {
                string symp = "Throat";
                con.Open();
                SqlCommand cmd8 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd8.Parameters.AddWithValue("@patient_id1", mrn);
                cmd8.Parameters.AddWithValue("@code1", apc);
                cmd8.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox8.Text;
                cmd8.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd8.Parameters.AddWithValue("@datestamp1", d);
                cmd8.Parameters.AddWithValue("@review_type1", symp);
                cmd8.ExecuteNonQuery();
                con.Close();
                TextBox8.Text = "";
            }

            TextBox9.Text = "Breast: ";
            if (CheckBox54.Checked == true)
            {
                TextBox9.Text = TextBox9.Text + "Lumps | ";
            }
            if (CheckBox57.Checked == true)
            {
                TextBox9.Text = TextBox9.Text + "Pain | ";
            }

            if (CheckBox55.Checked == true)
            {
                TextBox9.Text = TextBox9.Text + "Discharge | ";
            }
            if (CheckBox56.Checked == true)
            {
                TextBox9.Text = TextBox9.Text + "Breast feeding | ";
            }
            if (CheckBox58.Checked == true)
            {
                TextBox9.Text = TextBox9.Text + "self exams | ";
            }
            if (CheckBox54.Checked == true || CheckBox57.Checked == true || CheckBox55.Checked == true || CheckBox56.Checked == true || CheckBox58.Checked == true)
            {
                string symp = "Breast";
                con.Open();
                SqlCommand cmd9 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd9.Parameters.AddWithValue("@patient_id1", mrn);
                cmd9.Parameters.AddWithValue("@code1", apc);
                cmd9.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox9.Text;
                cmd9.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd9.Parameters.AddWithValue("@datestamp1", d);
                cmd9.Parameters.AddWithValue("@review_type1", symp);
                cmd9.ExecuteNonQuery();
                con.Close();
                TextBox9.Text = "";
            }


            TextBox10.Text = "Respiratory: ";
            if (CheckBox59.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Cough(dry or wet,productive) | ";
            }
            if (CheckBox62.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Sputum(color and amount) | ";
            }
            if (CheckBox60.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Coughing up blood(hemoptysis) | ";
            }
            if (CheckBox63.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Shorteness of breath(dyspnea) | ";
            }
            if (CheckBox61.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Wheezing | ";
            }
            if (CheckBox64.Checked == true)
            {
                TextBox10.Text = TextBox10.Text + "Painful breathing | ";
            }
            if (CheckBox59.Checked == true || CheckBox62.Checked == true || CheckBox60.Checked == true || CheckBox63.Checked == true || CheckBox61.Checked == true || CheckBox64.Checked == true)
            {
                string symp = "Respiratory";
                con.Open();
                SqlCommand cmd10 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd10.Parameters.AddWithValue("@patient_id1", mrn);
                cmd10.Parameters.AddWithValue("@code1", apc);
                cmd10.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox10.Text;
                cmd10.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd10.Parameters.AddWithValue("@datestamp1", d);
                cmd10.Parameters.AddWithValue("@review_type1", symp);
                cmd10.ExecuteNonQuery();
                con.Close();
                TextBox10.Text = "";
            }

            TextBox11.Text = "Cardiovascular: ";
            if (CheckBox65.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Chest pain and discomfort | ";
            }
            if (CheckBox66.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Difficulty breathing lying down(orthopnea) | ";
            }
            if (CheckBox67.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Sudden awakening from sleep with shortness of breath(Paroxysmal) | ";
            }
            if (CheckBox68.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Tightness | ";
            }
            if (CheckBox69.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Swelling(edima) | ";
            }
            if (CheckBox70.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Palpitations | ";
            }
            if (CheckBox71.Checked == true)
            {
                TextBox11.Text = TextBox11.Text + "Shorteness of breath with activity(dyspnea) | ";
            }
            if (CheckBox65.Checked == true || CheckBox66.Checked == true || CheckBox67.Checked == true || CheckBox68.Checked == true || CheckBox69.Checked == true || CheckBox70.Checked == true || CheckBox71.Checked == true)
            {
                string symp = "Cardiovascular";
                con.Open();
                SqlCommand cmd11 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd11.Parameters.AddWithValue("@patient_id1", mrn);
                cmd11.Parameters.AddWithValue("@code1", apc);
                cmd11.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox11.Text;
                cmd11.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd11.Parameters.AddWithValue("@datestamp1", d);
                cmd11.Parameters.AddWithValue("@review_type1", symp);
                cmd11.ExecuteNonQuery();
                con.Close();
                TextBox11.Text = "";
            }

            TextBox12.Text = "Gastrointestinal: ";
            if (CheckBox72.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Swallowing difficulties | ";
            }
            if (CheckBox73.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Change in bowel habbits | ";
            }
            if (CheckBox74.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Yellow eyes or skin(jaundice) | ";
            }
            if (CheckBox75.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Heartburn | ";
            }
            if (CheckBox76.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Rectal bleeding | ";
            }
            if (CheckBox77.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Change in appetite | ";
            }
            if (CheckBox78.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Constipation | ";
            }
            if (CheckBox79.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Nausea | ";
            }
            if (CheckBox80.Checked == true)
            {
                TextBox12.Text = TextBox12.Text + "Diarrhea | ";
            }
            if (CheckBox72.Checked == true || CheckBox73.Checked == true || CheckBox74.Checked == true || CheckBox75.Checked == true || CheckBox76.Checked == true
            || CheckBox77.Checked == true || CheckBox78.Checked == true || CheckBox79.Checked == true || CheckBox80.Checked == true)
            {
                string symp = "Gastrointestinal";
                con.Open();
                SqlCommand cmd12 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd12.Parameters.AddWithValue("@patient_id1", mrn);
                cmd12.Parameters.AddWithValue("@code1", apc);
                cmd12.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox12.Text;
                cmd12.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd12.Parameters.AddWithValue("@datestamp1", d);
                cmd12.Parameters.AddWithValue("@review_type1", symp);
                cmd12.ExecuteNonQuery();
                con.Close();
                TextBox12.Text = "";
            }

            TextBox13.Text = "Urinary: ";
            if (CheckBox81.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Frequency | ";
            }
            if (CheckBox82.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Blood in urine(hematuria) | ";
            }
            if (CheckBox84.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Change in urinary strength | ";
            }
            if (CheckBox85.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Urgency | ";
            }
            if (CheckBox87.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Burning or pain | ";
            }
            if (CheckBox88.Checked == true)
            {
                TextBox13.Text = TextBox13.Text + "Incontinence | ";
            }
            if (CheckBox81.Checked == true || CheckBox82.Checked == true || CheckBox84.Checked == true || CheckBox85.Checked == true || CheckBox87.Checked == true || CheckBox88.Checked == true)
            {
                string symp = "Urinary";
                con.Open();
                SqlCommand cmd13 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd13.Parameters.AddWithValue("@patient_id1", mrn);
                cmd13.Parameters.AddWithValue("@code1", apc);
                cmd13.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox13.Text;
                cmd13.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd13.Parameters.AddWithValue("@datestamp1", d);
                cmd13.Parameters.AddWithValue("@review_type1", symp);
                cmd13.ExecuteNonQuery();
                con.Close();
                TextBox13.Text = "";
            }

            TextBox14.Text = "Genital-Male: ";
            if (CheckBox83.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Pain with sex | ";
            }
            if (CheckBox86.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Sores | ";
            }
            if (CheckBox93.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "STD's | ";
            }
            if (CheckBox89.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Hernia | ";
            }
            if (CheckBox90.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Masses or pain | ";
            }
            if (CheckBox94.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Penile discharge | ";
            }
            if (CheckBox91.Checked == true)
            {
                TextBox14.Text = TextBox14.Text + "Erectile dysfunction | ";
            }
            if (CheckBox83.Checked == true || CheckBox86.Checked == true || CheckBox93.Checked == true || CheckBox89.Checked == true || CheckBox90.Checked == true || CheckBox94.Checked == true
              || CheckBox91.Checked == true)
            {
                string symp = "Genital-Male";
                con.Open();
                SqlCommand cmd14 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd14.Parameters.AddWithValue("@patient_id1", mrn);
                cmd14.Parameters.AddWithValue("@code1", apc);
                cmd14.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox14.Text;
                cmd14.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd14.Parameters.AddWithValue("@datestamp1", d);
                cmd14.Parameters.AddWithValue("@review_type1", symp);
                cmd14.ExecuteNonQuery();
                con.Close();
                TextBox14.Text = "";
            }


            TextBox15.Text = "Genital-Female: ";
            if (CheckBox92.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "Pain with sex | ";
            }
            if (CheckBox95.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "Hot flashes | ";
            }
            if (CheckBox97.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "Itching or rash | ";
            }
            if (CheckBox98.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "Vaginal dryness | ";
            }
            if (CheckBox100.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "Vaginal discharge | ";
            }
            if (CheckBox96.Checked == true)
            {
                TextBox15.Text = TextBox15.Text + "STD's | ";
            }
            if (CheckBox92.Checked == true || CheckBox95.Checked == true || CheckBox97.Checked == true || CheckBox98.Checked == true || CheckBox100.Checked == true || CheckBox96.Checked == true)

            {
                string symp = "Genital-Female";
                con.Open();
                SqlCommand cmd15 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd15.Parameters.AddWithValue("@patient_id1", mrn);
                cmd15.Parameters.AddWithValue("@code1", apc);
                cmd15.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox15.Text;
                cmd15.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd15.Parameters.AddWithValue("@datestamp1", d);
                cmd15.Parameters.AddWithValue("@review_type1", symp);
                cmd15.ExecuteNonQuery();
                con.Close();
                TextBox15.Text = "";
            }

            TextBox16.Text = "Vascular: ";
            if (CheckBox99.Checked == true)
            {
                TextBox16.Text = TextBox16.Text + "Calf pain with walking(Claudication) | ";
            }
            if (CheckBox104.Checked == true)
            {
                TextBox16.Text = TextBox16.Text + "Leg cramping | ";
            }
            if (CheckBox99.Checked == true || CheckBox104.Checked == true)

            {
                string symp = "Vascular";
                con.Open();
                SqlCommand cmd16 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd16.Parameters.AddWithValue("@patient_id1", mrn);
                cmd16.Parameters.AddWithValue("@code1", apc);
                cmd16.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox16.Text;
                cmd16.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd16.Parameters.AddWithValue("@datestamp1", d);
                cmd16.Parameters.AddWithValue("@review_type1", symp);
                cmd16.ExecuteNonQuery();
                con.Close();
                TextBox16.Text = "";
            }
            TextBox17.Text = "Musculoskeletal: ";
            if (CheckBox101.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Muscle or joint pain | ";
            }
            if (CheckBox102.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Back pain | ";
            }
            if (CheckBox103.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Swelling of joints | ";
            }
            if (CheckBox105.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Stiffness | ";
            }
            if (CheckBox106.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Redness of joints | ";
            }
            if (CheckBox107.Checked == true)
            {
                TextBox17.Text = TextBox17.Text + "Trauma | ";
            }
            if (CheckBox101.Checked == true || CheckBox102.Checked == true || CheckBox103.Checked == true || CheckBox105.Checked == true || CheckBox106.Checked == true || CheckBox107.Checked == true)

            {
                string symp = "Musculoskeletal";
                con.Open();
                SqlCommand cmd17 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd17.Parameters.AddWithValue("@patient_id1", mrn);
                cmd17.Parameters.AddWithValue("@code1", apc);
                cmd17.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox17.Text;
                cmd17.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd17.Parameters.AddWithValue("@datestamp1", d);
                cmd17.Parameters.AddWithValue("@review_type1", symp);
                cmd17.ExecuteNonQuery();
                con.Close();
                TextBox17.Text = "";
            }

            TextBox18.Text = "Hematologic: ";
            if (CheckBox108.Checked == true)
            {
                TextBox18.Text = TextBox18.Text + "Ease of bruising | ";
            }
            if (CheckBox111.Checked == true)
            {
                TextBox18.Text = TextBox18.Text + "Ease of bleeding | ";
            }
            if (CheckBox108.Checked == true || CheckBox111.Checked == true)

            {
                string symp = "Hematologic";
                con.Open();
                SqlCommand cmd18 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd18.Parameters.AddWithValue("@patient_id1", mrn);
                cmd18.Parameters.AddWithValue("@code1", apc);
                cmd18.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox18.Text;
                cmd18.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd18.Parameters.AddWithValue("@datestamp1", d);
                cmd18.Parameters.AddWithValue("@review_type1", symp);
                cmd18.ExecuteNonQuery();
                con.Close();
                TextBox18.Text = "";
            }

            TextBox19.Text = "Neurologic: ";
            if (CheckBox109.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Dizziness | ";
            }
            if (CheckBox110.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Weakness | ";
            }
            if (CheckBox112.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Tremor | ";
            }
            if (CheckBox113.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Fainting | ";
            }
            if (CheckBox114.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Numbness | ";
            }
            if (CheckBox115.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Siezures | ";
            }
            if (CheckBox116.Checked == true)
            {
                TextBox19.Text = TextBox19.Text + "Tingling | ";
            }
            if (CheckBox109.Checked == true || CheckBox110.Checked == true || CheckBox112.Checked == true || CheckBox113.Checked == true
              || CheckBox114.Checked == true || CheckBox115.Checked == true || CheckBox116.Checked == true)

            {
                string symp = "Neurologic";
                con.Open();
                SqlCommand cmd19 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd19.Parameters.AddWithValue("@patient_id1", mrn);
                cmd19.Parameters.AddWithValue("@code1", apc);
                cmd19.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox19.Text;
                cmd19.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd19.Parameters.AddWithValue("@datestamp1", d);
                cmd19.Parameters.AddWithValue("@review_type1", symp);
                cmd19.ExecuteNonQuery();
                con.Close();
                TextBox19.Text = "";
            }

            TextBox20.Text = "Psychiatric: ";
            if (CheckBox118.Checked == true)
            {
                TextBox20.Text = TextBox20.Text + "Nervousness | ";
            }
            if (CheckBox128.Checked == true)
            {
                TextBox20.Text = TextBox20.Text + "Memory loss | ";
            }
            if (CheckBox119.Checked == true)
            {
                TextBox20.Text = TextBox20.Text + "Stress | ";
            }
            if (CheckBox129.Checked == true)
            {
                TextBox20.Text = TextBox20.Text + "Depression | ";
            }
            if (CheckBox118.Checked == true || CheckBox128.Checked == true || CheckBox119.Checked == true || CheckBox129.Checked == true)

            {
                string symp = "Psychiatric";
                con.Open();
                SqlCommand cmd20 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd20.Parameters.AddWithValue("@patient_id1", mrn);
                cmd20.Parameters.AddWithValue("@code1", apc);
                cmd20.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox20.Text;
                cmd20.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd20.Parameters.AddWithValue("@datestamp1", d);
                cmd20.Parameters.AddWithValue("@review_type1", symp);
                cmd20.ExecuteNonQuery();
                con.Close();
                TextBox20.Text = "";
            }
            TextBox21.Text = "Endocrine: ";
            if (CheckBox121.Checked == true)
            {
                TextBox21.Text = TextBox21.Text + "Head or cold intolerance | ";
            }
            if (CheckBox122.Checked == true)
            {
                TextBox21.Text = TextBox21.Text + "Frequent urination(polyuria) | ";
            }
            if (CheckBox124.Checked == true)
            {
                TextBox21.Text = TextBox21.Text + "Change in appetite(polyphagia) | ";
            }
            if (CheckBox125.Checked == true)
            {
                TextBox21.Text = TextBox21.Text + "Sweating | ";
            }
            if (CheckBox127.Checked == true)
            {
                TextBox21.Text = TextBox21.Text + "Thirst(polydypsia) | ";
            }
            if (CheckBox121.Checked == true || CheckBox122.Checked == true || CheckBox124.Checked == true || CheckBox125.Checked == true || CheckBox127.Checked == true)

            {
                string symp = "Endocrine";
                con.Open();
                SqlCommand cmd21 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);
                cmd21.Parameters.AddWithValue("@patient_id1", mrn);
                cmd21.Parameters.AddWithValue("@code1", apc);
                cmd21.Parameters.AddWithValue("@value1", "ROS");
                string des = TextBox21.Text;
                cmd21.Parameters.AddWithValue("@note1", des);
                string d = DateTime.Now.ToString();
                cmd21.Parameters.AddWithValue("@datestamp1", d);
                cmd21.Parameters.AddWithValue("@review_type1", symp);
                cmd21.ExecuteNonQuery();
                con.Close();
                TextBox21.Text = "";
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";
            TextBox16.Text = "";
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";

        }
    }
}