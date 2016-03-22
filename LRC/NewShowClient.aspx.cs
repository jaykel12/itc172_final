using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewShowClient : System.Web.UI.Page
{

    RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
    SelectService.SelectServiceClient ssc = new SelectService.SelectServiceClient();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ReviewerKey"] != null)
        {
            if (!IsPostBack)
            {
                PopulateArtistList();
                Panel1.Visible = false;
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void PopulateArtistList()
    {
        string[] artists = ssc.GetArtistName();
        ArtistDropDownList.DataSource = artists;
        ArtistDropDownList.DataBind();
        ArtistDropDownList.Items.Add("New Artist");
    }

    protected void ArtistDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ArtistDropDownList.SelectedItem.Text.Equals("New Artist"))
        {
            Panel1.Visible = true;
        }
    }

    protected void AddShow()
    {
        RegistrationService.NewShow na = new RegistrationService.NewShow();
        na.ShowName = ShowNameTextBox.Text;
        na.ShowDate = DateTime.Parse(ShowDateTextBox.Text);
        na.ShowTime = TimeSpan.Parse(ShowTimeTextBox.Text);
        na.ShowTicketInfo = ShowTicketInfoTextBox.Text;

        string[] artist = new string[1];
        if(ArtistDropDownList.SelectedItem.Text.Equals("New Artist"))
        {
            artist[0] = ArtistNameTextBox.Text;
        }
        else
        {
            artist[0] = ArtistDropDownList.SelectedItem.Text;
        }

        lsc.AddShow(na);

        PopulateArtistList();

    }

    protected void AddArtistButton_Click(object sender, EventArgs e)
    {
        AddShow();
    }
}