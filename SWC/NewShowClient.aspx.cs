using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewShowClient : System.Web.UI.Page
{

    SelectWebClientServiceReference.SelectServiceClient db =
   new SelectWebClientServiceReference.SelectServiceClient();

    SelectService.LoginServiceClient lsc = new SelectService.LoginServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateArtistList();
        }
    }

    protected void PopulateArtistList()
    {
        string[] artists = db.GetArtistName();
        ArtistDropDownList.DataSource = artists;
        ArtistDropDownList.DataBind();
        ArtistDropDownList.Items.Add("New Artist");
    }
}