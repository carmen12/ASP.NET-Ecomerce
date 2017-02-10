using Microsoft.Owin.Security;
using System;
using System.Web;

public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;

        if(user.IsAuthenticated)
        {
            lblStatus.Text = user.Name;

            lnkLogin.Visible = false;
            lnkRegister.Visible = false;

            lnkLogout.Visible = true;
            lblStatus.Visible = true;
        }
        else
        {
            lnkLogin.Visible = true;
            lnkRegister.Visible = true;

            lnkLogout.Visible = false;
            lblStatus.Visible = false;
        }
    }

    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        authenticationManager.SignOut();
        Response.Redirect("~/Index.aspx");
    }
}
