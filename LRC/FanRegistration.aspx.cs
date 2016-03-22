using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanRegistration : System.Web.UI.Page
{
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterFan();
    }

    protected void RegisterFan()
    {
        RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
        RegistrationService.FanLite fLite = new RegistrationService.FanLite();
        fLite.FanName = FanNameTextBox.Text;
        fLite.FanEmail = EmailTextBox.Text;
        fLite.FanUsername = UsernameTextBox.Text;
        fLite.fanPassword = PasswordTextBox.Text;

        try
        {
            int result = lsc.FanRegistration(fLite);
            if (result != 1)
                Response.Redirect("FanLogin.aspx");
            else
                ErrorLabel.Text = "Registration Not Processed";
        }
        catch (Exception ex)
        {
            ErrorLabel.Text = ex.Message;
        }
    }
}