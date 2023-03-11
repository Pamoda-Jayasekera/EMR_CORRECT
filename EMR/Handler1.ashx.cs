using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Configuration;

namespace EMR
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
                string term = context.Request["term"] ?? "";
                List<string> DrugsListCSV = new List<string>();
                string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con1 = new SqlConnection(cs))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("spDrugNames", con1);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = "@term",
                            Value = term
                        });
                        con1.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                        DrugsListCSV.Add(rdr["Generic_Name"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception here
                        // For example, you could log the error or return an error message to the client
                        context.Response.Write("An error occurred: " + ex.Message);
                    }
                }
                JavaScriptSerializer js = new JavaScriptSerializer();
                context.Response.Write(js.Serialize(DrugsListCSV));
            }


        

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}