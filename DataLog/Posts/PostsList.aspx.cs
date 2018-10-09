using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLog.Models;

namespace DataLog.Posts
{
    public partial class PostsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateHyperLink.NavigateUrl = "Create";
            var db = new ApplicationDbContext();

        }
    }
}