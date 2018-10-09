using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALUserLog;
using DataLog.Models;
using  Microsoft.AspNet.Identity;

namespace DataLog.Posts
{
    public partial class PostsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateHyperLink.NavigateUrl = "Create";
            var db = new ApplicationDbContext();

        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            var userId = User.Identity.GetUserId();
            var email = User.Identity.GetUserName();

            var userLog = new DALUserLog.UserLog
            {
                UserId = userId,
                Action = "Update",
                Details = "Post Updated ",
                Email = email,
                SendingDate = DateTime.UtcNow
            };

            LogService.AddLog(userLog);
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            var userId = User.Identity.GetUserId();
            var email = User.Identity.GetUserName();

            var userLog = new DALUserLog.UserLog
            {
                UserId = userId,
                Action = "Deleted",
                Details = "Post deleted ",
                Email = email,
                SendingDate = DateTime.UtcNow
            };

            LogService.AddLog(userLog);
        }
    }
}