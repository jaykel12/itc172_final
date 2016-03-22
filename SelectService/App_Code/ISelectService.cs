using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISelectService" in both code and config file together.
[ServiceContract]
public interface ISelectService
{
    [OperationContract]
    List<string> GetArtistName();
    [OperationContract]
    List<string> GetShowName();
    [OperationContract]
    List<string> GetShowDate();
    [OperationContract]
    List<string> GetShowTime();
    [OperationContract]
    List<VenLite> GetVenueName(string venueName);
    [OperationContract]
    List<ShowLite> GetArtName(string artistName);
    [OperationContract]
    List<VenDetailLite> GetVenueDetail(string venDetail);
    [OperationContract]
    List<ShowDetailLite> GetShowDetail(string showDetail);
}

[DataContract]
public class VenLite
{
    [DataMember]
    public string VenueName { set; get; }
}

[DataContract]
public class ShowLite
{
    [DataMember]
    public string ShowName { set; get; }
    [DataMember]
    public string Showtime { set; get; }
    [DataMember]
    public string ShowDate { set; get; }
}

[DataContract]
public class VenDetailLite
{
    [DataMember]
    public string VenueName { set; get; }
    [DataMember]
    public string ArtistName { set; get; }
    [DataMember]
    public string ShowName { set; get; }
}

[DataContract]
public class ShowDetailLite
{
    [DataMember]
    public string VenueName { set; get; }
    [DataMember]
    public string ArtistName { set; get; }
    [DataMember]
    public string ShowName { set; get; }
}