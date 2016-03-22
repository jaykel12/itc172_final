using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //connect to service reference
    SelectWebClientServiceReference.SelectServiceClient db =
    new SelectWebClientServiceReference.SelectServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {//if !IsPostBack execute LoadDropDown
        if (!IsPostBack)
        {
            LoadDropDown();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {//execute fillgrid when artist name is selected
        fillGrid();
    }

      protected void LoadDropDown()
    {//grabs artist names from GetArtistName
        string[] artistName = db.GetArtistName();
        DropDownList1.DataSource = artistName;
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Select Artist");

        string[] showName = db.GetShowName();
        DropDownList2.DataSource = showName;
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "Select Show");

    }

    protected void fillGrid()
    {//fills grid with artist names
        string artist = DropDownList1.SelectedItem.Text;
        SelectWebClientServiceReference.VenDetailLite[] venues = db.GetVenueDetail(artist);
        GridView1.DataSource = venues;
        GridView1.DataBind();

        string show = DropDownList2.SelectedItem.Text;
        SelectWebClientServiceReference.ShowDetailLite[] shows = db.GetShowDetail(show);
        GridView2.DataSource = shows;
        GridView2.DataBind();
    }

}