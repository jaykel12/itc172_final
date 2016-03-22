using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterVenue();
    }

    protected void RegisterVenue()
    {
        RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
        RegistrationService.VenueLite vLite = new RegistrationService.VenueLite();
        vLite.VenueName = VenueNameTextBox.Text;
        vLite.VenueAddress = AddressTextBox.Text;
        vLite.VenueCity = CityTextBox.Text;
        vLite.VenueZipCode = ZipCodeTextBox.Text;
        vLite.VenueWebPage = WebPageTextBox.Text;
        vLite.VenueAgeRestriction = int.Parse(AgeRestrictionTextBox.Text);
        vLite.VenueEmail = EmailTextBox.Text;
        vLite.VenuePhone = PhoneNumberTextBox.Text;
        vLite.VenueLoginUserName = UserNameTextBox.Text;
        vLite.VenueLoginPasswordPlain = ConfirmTextBox.Text;

        try
        {
            int result = lsc.VenueRegistration(vLite);
            if (result != 1)
                Response.Redirect("Login.aspx");
            else
                ErrorLabel.Text = "Registration Not Processed";
        }
        catch(Exception ex)
        {
            ErrorLabel.Text = ex.Message;
        }
    }
}