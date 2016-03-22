using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        VenueLogin();
    }

    protected void VenueLogin()
    {
        RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
        int key = lsc.VenueLogin(VenueNameTextBox.Text, PasswordTextBox.Text);
        if (key != -1)
        {
            Session["VenueKey"] = key;
            ResultLabel.Text = "Welcome";
        }
        else
            ResultLabel.Text = "Invalid Login";
    }
}