using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALUserLog;
using Microsoft.AspNet.Identity;


namespace DataLog.Logs

{
    public partial class MyLogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userId = User.Identity.GetUserId();
            var data = LogService.GetLogs(userId);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}