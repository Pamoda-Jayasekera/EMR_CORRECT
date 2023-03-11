using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EMR
{
    /// <summary>
    /// Summary description for Handler3
    /// </summary>
    public class Handler3 : IHttpHandler
    {

        //string strcon = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        public void ProcessRequest(HttpContext context)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRUK56G;Initial Catalog=EMR_DB;Integrated Security=True");

            //string imageid = context.Request.QueryString["ImID"];
            con.Open();
            SqlCommand command = new SqlCommand("select lab_report from Lab_Reports where patient_id=" + 1, con);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read()) { 
                context.Response.BinaryWrite((Byte[])dr[0]);
                con.Close();
                context.Response.End();
            }
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