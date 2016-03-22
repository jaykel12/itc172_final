using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SelectService" in code, svc and config file together.
public class SelectService : ISelectService
{
    ShowTrackerEntities st = new ShowTrackerEntities();


    List<string> ISelectService.GetArtistName()
    {
        var artist_name = from a in st.Artists
                          orderby a.ArtistName
                          select new { a.ArtistName };

        List<string> art_name = new List<string>();
        foreach (var au in artist_name)
        {
            art_name.Add(au.ArtistName.ToString());
        }
        return art_name;
    }

    List<string> ISelectService.GetShowName()
    {
        var show_name = from a in st.Shows
                        orderby a.ShowName
                        select new { a.ShowName };

        List<string> sho_name = new List<string>();
        foreach (var au in show_name)
        {
            sho_name.Add(au.ShowName.ToString());
        }
        return sho_name;
    }

    List<string> ISelectService.GetShowDate()
    {
        var show_date = from a in st.Shows
                        orderby a.ShowDate
                        select new { a.ShowDate };

        List<string> sho_date = new List<string>();
        foreach (var au in show_date)
        {
            sho_date.Add(au.ShowDate.ToString());
        }
        return sho_date;
    }

    List<string> ISelectService.GetShowTime()
    {
        var show_time = from a in st.Shows
                        orderby a.ShowTime
                        select new { a.ShowTime };

        List<string> sho_time = new List<string>();
        foreach (var au in show_time)
        {
            sho_time.Add(au.ShowTime.ToString());
        }
        return sho_time;
    }


    List<VenLite> ISelectService.GetVenueName(string venueName)
    {
        var vns = from b in st.Venues
                  from a in b.Shows
                  from c in a.ShowDetails
                  where c.Artist.ArtistName == venueName
                  select new { b.VenueName };

        List<VenLite> venNam = new List<VenLite>();

        foreach (var b in vns)
        {
            VenLite vlite = new VenLite();
            vlite.VenueName = b.VenueName;

            venNam.Add(vlite);
        }

        return venNam;


    }


    List<ShowLite> ISelectService.GetArtName(string artistName)
    {
        var shws = from s in st.Shows
                   from sd in s.ShowDetails
                   where sd.Artist.ArtistName == artistName
                   select new { s.ShowName, s.ShowTime, s.ShowDate };
        List<ShowLite> shwNam = new List<ShowLite>();

        foreach (var s in shws)
        {
            ShowLite slite = new ShowLite();
            slite.ShowDate = s.ShowDate.ToShortDateString();
            slite.Showtime = s.ShowTime.ToString();
            slite.ShowName = s.ShowName;

            shwNam.Add(slite);
        }
        return shwNam;
    }

    List<VenDetailLite> ISelectService.GetVenueDetail(string venueDetail)
    {
        var venDet = from b in st.Artists
                   from s in b.ShowDetails
                   where s.Artist.ArtistName == venueDetail
                   select new { s.Show.Venue.VenueName, b.ArtistName, s.Show.ShowName};
        List<VenDetailLite> shwVenDet = new List<VenDetailLite>();

        foreach (var s in venDet)
        {
            VenDetailLite vdlite = new VenDetailLite();
            vdlite.VenueName = s.VenueName;
            vdlite.ArtistName = s.ArtistName;
            vdlite.ShowName = s.ShowName;

            shwVenDet.Add(vdlite);
        }
        return shwVenDet;
    }

    List<ShowDetailLite> ISelectService.GetShowDetail(string showDetail)
    {
        var shwDet = from b in st.Artists
                     from s in b.ShowDetails
                     where s.Show.ShowName == showDetail
                     select new { s.Show.Venue.VenueName, b.ArtistName, s.Show.ShowName };
        List<ShowDetailLite> shwShoDet = new List<ShowDetailLite>();

        foreach (var s in shwDet)
        {
            ShowDetailLite sdlite = new ShowDetailLite();
            sdlite.VenueName = s.VenueName;
            sdlite.ArtistName = s.ArtistName;
            sdlite.ShowName = s.ShowName;

            shwShoDet.Add(sdlite);
        }
        return shwShoDet;
    }
}
