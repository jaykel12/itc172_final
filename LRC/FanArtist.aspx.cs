using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FanArtist : System.Web.UI.Page
{
    RegistrationService.LoginServiceClient lsc = new RegistrationService.LoginServiceClient();
    SelectService.SelectServiceClient ssc = new SelectService.SelectServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        //I hard coded the key in so I didn't have to do the login 
        //for this example
        Session["key"] = 2;
        if (!IsPostBack)
            PopulateArtists();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        AddArtists();
    }

    protected void PopulateArtists()
    {
        string[] artists = ssc.GetArtistName();
        ArtistCheckBoxList.DataSource = artists;
        ArtistCheckBoxList.DataBind();
    }

    protected void AddArtists()
    {
        int key = (int)Session["key"];


        foreach (ListItem i in ArtistCheckBoxList.Items)
        {

            if (i.Selected)
            {
                int x = lsc.AddFanArtist(key, i.Text);
            }
        }
        Label1.Text = "Artist have been added";
        ArtistCheckBoxList.Items.Clear();
    }
}