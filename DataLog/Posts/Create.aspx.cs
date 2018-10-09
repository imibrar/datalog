using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLog.Models;

namespace DataLog.Posts
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPost_Click(object sender, EventArgs e)
        {
            //var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //var code = manager.GenerateChangePhoneNumberToken(User.Identity.GetUserId(), PhoneNumber.Text);
            //if (manager.SmsService != null)
            //{
            //    var message = new IdentityMessage
            //    {
            //        Destination = PhoneNumber.Text,
            //        Body = "Your security code is " + code
            //    };

            //    manager.SmsService.Send(message);
            //}

            if (!String.IsNullOrEmpty(Title1.Text) && !String.IsNullOrEmpty(Details.Text))
            {
                var db = new ApplicationDbContext();
                db.Posts.Add(new Post()
                {
                    Title = Title1.Text,
                    Details = Details.Text
                });
                db.SaveChanges();

                Response.Redirect("/Posts/PostsList");
            }
            ModelState.AddModelError("", "Please Fill All Fields");
        }
    }
}