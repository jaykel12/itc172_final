using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
public class LoginService : ILoginService
{

    public void AddShow(NewShow a)
    {
        Show show = new Show();
        show.ShowKey = a.ShowKey;
        show.ShowName = a.ShowName;
        show.ShowDate = a.ShowDate;
        show.ShowDateEntered = DateTime.Now;
        show.ShowTime = a.ShowTime;
        show.ShowTicketInfo = a.ShowTicketInfo;
        show.VenueKey = a.VenueKey;

        db.Shows.Add(show);
        db.SaveChanges();

    }

    public void AddShowDetails(NewShowDetails b)
    {
        ShowDetail showDetail = new ShowDetail();
        showDetail.ShowDetailKey = b.ShowDetailKey;
        showDetail.ShowKey = b.ShowKey;
        showDetail.ArtistKey = b.ArtistKey;
        showDetail.ShowDetailArtistStartTime = b.ShowDetailArtistStartTime;
        showDetail.ShowDetailAdditional = b.ShowDetailAdditional;

        db.ShowDetails.Add(showDetail);
        db.SaveChanges();
    }

    public void AddArtist(NewArtist c)
    {
        Artist artist = new Artist();
        artist.ArtistName = c.ArtistName;
        artist.ArtistEmail = c.ArtistEmail;
        artist.ArtistKey = c.ArtistKey;
        artist.ArtistWebPage = c.ArtistWebPage;
        artist.ArtistDateEntered = DateTime.Now;

        db.Artists.Add(artist);
        db.SaveChanges();
    }

    ShowTrackerEntities db = new ShowTrackerEntities();
    public int VenueLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_venueLogin(username,password);
        if(pass != -1)
        {
            var ven = from r in db.VenueLogins
                      where r.VenueLoginUserName.Equals(username)
                      select new { r.VenueLoginKey };

            foreach (var r in ven)
            {
                key = (int)r.VenueLoginKey;
            }
        }

        return key;
    }

    public int VenueRegistration(VenueLite r)
    {
        int worked = db.usp_RegisterVenue
            (r.VenueName, r.VenueAddress, r.VenueCity, r.VenueState,r.VenueZipCode, r.VenuePhone, r.VenueEmail, r.VenueWebPage, r.VenueAgeRestriction, r.VenueLoginUserName, r.VenueLoginPasswordPlain);
        return worked;
    }

    public int FanLogin(string username, string password)
    {
        int key = 0;
        int pass = db.usp_FanLogin(username, password);
        if (pass != -1)
        {
            var fan = from r in db.FanLogins
                      where r.FanLoginUserName.Equals(username)
                      select new { r.FanLoginKey};

            foreach (var r in fan)
            {
                key = (int)r.FanLoginKey;
            }
        }

        return key;
    }

    public int FanRegistration(FanLite x)
    {
        int worked = db.usp_RegisterFan(x.FanName, x.FanEmail, x.FanUsername, x.fanPassword);
        return worked;
    }

    public int AddFanArtist(int fanKey, string artistName)
    {
        int result = 1;

        Fan myFan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        Artist myArtist = (from a in db.Artists
                           where a.ArtistName.Equals(artistName)
                           select a).First();

        myFan.Artists.Add(myArtist);

        db.SaveChanges();

        return result;
    }

    public List<ShowInfo> GetShowsForFanArtist(int fanKey)
    {
        //get the fan
        Fan myFan = (from f in db.Fans
                     where f.FanKey == fanKey
                     select f).First();

        List<ShowInfo> shows = new List<ShowInfo>();

        //this loop within a loop is very inefficient
        foreach (Artist a in myFan.Artists)
        {
            //get all the shows for the fan
            var shws = from s in db.Shows
                       from sd in s.ShowDetails
                       where sd.ArtistKey == a.ArtistKey
                       select new
                       {
                           s.ShowName,
                           s.ShowTime,
                           s.ShowDate,
                           s.ShowTicketInfo,
                           s.Venue.VenueName,
                           sd.Artist.ArtistName
                       };

            //loop through the shows and write them to 
            //ShowInfo objects then add those objects
            //to the list
            foreach (var sh in shws)
            {
                ShowInfo info = new ShowInfo();
                info.ShowName = sh.ShowName;
                info.ShowDate = sh.ShowDate.ToString();
                info.ShowTime = sh.ShowTime.ToString();
                info.TicketInfo = sh.ShowTicketInfo;
                info.VenueName = sh.VenueName;
                info.ArtistName = sh.ArtistName;

                shows.Add(info);
            }


        }
        return shows;
    }
}
