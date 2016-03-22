using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanLogin : System.Web.UI.Page
{
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        Login();
    }

    protected void Login()
    {
        RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
        int key = lsc.FanLogin(FanNameTextBox.Text, PasswordTextBox.Text);
        if (key != -1)
        {
            Session["FanKey"] = key;
            ResultLabel.Text = "Welcome";
        }
        else
            ResultLabel.Text = "Invalid Login";
    }
}