using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginService" in both code and config file together.
[ServiceContract]
public interface ILoginService
{
    [OperationContract]
    int VenueLogin(string username, string password);

    [OperationContract]
    int VenueRegistration(VenueLite r);

    [OperationContract]
    void AddShow(NewShow a);

    [OperationContract]
    void AddShowDetails(NewShowDetails b);

    [OperationContract]
    void AddArtist(NewArtist c);

    [OperationContract]
    int FanLogin(string username, string password);

    [OperationContract]
    int FanRegistration(FanLite x);

    [OperationContract]
    int AddFanArtist(int fanKey, string artistName);

    [OperationContract]
    List<ShowInfo> GetShowsForFanArtist(int fanKey);
}

[DataContract]

public class ShowInfo
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public string ShowTime { set; get; }

    [DataMember]
    public string ShowDate { set; get; }

    [DataMember]
    public string TicketInfo { set; get; }

    [DataMember]
    public string VenueName { set; get; }

    [DataMember]
    public string ArtistName { set; get; }

}

[DataContract]
public class FanLite
{
    [DataMember]
    public string FanName { set; get; }

    [DataMember]
    public string FanEmail { set; get; }

    [DataMember]
    public string FanUsername { set; get; }

    [DataMember]
    public string fanPassword { set; get; }
}

[DataContract]
public class VenueLite
{
    [DataMember]
    public string VenueName { set; get; }
    [DataMember]
    public string VenueAddress { set; get; }
    [DataMember]
    public string VenueCity { set; get; }
    [DataMember]
    public string VenueState { set; get; }
    [DataMember]
    public string VenueZipCode { set; get; }
    [DataMember]
    public string VenuePhone { set; get; }
    [DataMember]
    public string VenueEmail { set; get; }
    [DataMember]
    public string VenueWebPage { set; get; }
    [DataMember]
    public int VenueAgeRestriction { set; get; }
    [DataMember]
    public string VenueLoginUserName { set; get; }
    [DataMember]
    public string VenueLoginPasswordPlain { set; get; }


}

[DataContract]
public class NewShow
{
    [DataMember]
    public int ShowKey { set; get; }
    [DataMember]
    public string ShowName { set; get; }
    [DataMember]
    public int VenueKey { set; get; }
    [DataMember]
    public DateTime ShowDate { set; get; }
    [DataMember]
    public TimeSpan ShowTime { set; get; }
    [DataMember]
    public string ShowTicketInfo { set; get; }
    [DataMember]
    public string ShowDateEntered { set; get; }
}

[DataContract]
public class NewShowDetails
{
    [DataMember]
    public int ShowDetailKey { set; get; }
    [DataMember]
    public int ShowKey { set; get; }
    [DataMember]
    public int ArtistKey { set; get; }
    [DataMember]
    public TimeSpan ShowDetailArtistStartTime { set; get; }
    [DataMember]
    public string ShowDetailAdditional { set; get; }
}

[DataContract]
public class NewArtist
{
    [DataMember]
    public int ArtistKey { set; get; }
    [DataMember]
    public string ArtistName { set; get; }
    [DataMember]
    public string ArtistEmail{ set; get; }
    [DataMember]
    public DateTime ArtistDateEntered{ set; get; }
    [DataMember]
    public string ArtistWebPage { set; get; }
}
