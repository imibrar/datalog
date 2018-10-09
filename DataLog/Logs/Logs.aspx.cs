using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALUserLog;

namespace DataLog.Logs
{
    public partial class Logs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = LogService.GetLogs();
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

    }
}