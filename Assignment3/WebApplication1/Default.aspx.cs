using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClass log = new LoginClass(TextPassword.Text, TextUsername.Text);
            int key = log.ValidateLogin();
            if (key != 0)
            {
                Session["UserKey"] = key;
                Response.Redirect("Welcome.aspx");
            }
            else {
                LabelResult.Text = "Invalid Log In";
            }
        }
    }
}