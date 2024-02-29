using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class _90DaySnap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string val1 = Session["smrn"].ToString();
            string val2 = Session["sapc"].ToString();
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
        }
    }
}