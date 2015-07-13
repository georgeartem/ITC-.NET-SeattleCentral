using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            ShowTrackerEntities ste = new ShowTrackerEntities();
            KeyCode k = new KeyCode();
            int seed = k.GetKeyCode();
            PasswordHash phash = new PasswordHash();

            try
            {
                byte[] pass = phash.HashIt(txtConfirm.Text, seed.ToString());
                FanLogin fnln = new FanLogin();
                Fan fn = new Fan();
                fn.FanName = txtFanName.Text;
                fn.FanEmail = txtEmail.Text;
                fnln.FanLoginRandom = seed;
                fnln.Fan = fn;
                fnln.FanLoginHashed = pass;
                fnln.FanLoginPasswordPlain = txtConfirm.Text;
                fnln.FanLoginDateAdded = DateTime.Now;

                ste.FanLogins.Add(fnln);
                ste.SaveChanges();
                lblErrorSuccess.Text = "You were successfully registered";
            }
            catch (Exception ex)
            {
                lblErrorSuccess.Text = ex.Message;
            }

        }
    }
}