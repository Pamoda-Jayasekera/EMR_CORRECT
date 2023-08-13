using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace EMR
{
    /// <summary>
    /// Summary description for WebServicePrediction
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class WebServicePrediction : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetSymptomNames(string term)
        {
            List<string> symptomNames = new List<string>();

            string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT symptom FROM Symptom_New WHERE symptom LIKE '%' + @term + '%'", con);
                cmd.Parameters.AddWithValue("@term", term);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    symptomNames.Add(rdr["symptom"].ToString());
                }

                return symptomNames;
            }
        }
    }
}