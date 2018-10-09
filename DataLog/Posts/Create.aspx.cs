using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALUserLog;
using DataLog.Models;
using Microsoft.AspNet.Identity;

namespace DataLog.Posts
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(Title1.Text) && !String.IsNullOrEmpty(Details.Text))
            {
                var db = new ApplicationDbContext();
                db.Posts.Add(new Post()
                {
                    Title = Title1.Text,
                    Details = Details.Text
                });
                db.SaveChanges();
                var userId = User.Identity.GetUserId();
                var email = User.Identity.GetUserName();

               // var logService = new LogService();
               // LogService.GetLogs(userId);
                var userLog = new DALUserLog.UserLog
                {
                    UserId = userId,
                    Action =  "Created",
                    Details = "A New Post Created",
                    Email = email,
                    SendingDate = DateTime.UtcNow
                };

                LogService.AddLog(userLog);


                Response.Redirect("/Posts/PostsList");
            }
            ModelState.AddModelError("", "Please Fill All Fields");
        }
    }
}