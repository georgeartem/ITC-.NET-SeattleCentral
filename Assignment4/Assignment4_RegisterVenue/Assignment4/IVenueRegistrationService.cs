using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


    [ServiceContract]
    public interface IVenueRegistrationService
    {
        [OperationContract]
        bool RegisterVenue(VenueLite v);

        [OperationContract]

        int VenueLogin(string VenueLoginUserName, string VenueLoginPasswordPlain);
    }

    [DataContract]

public class VenueLite
{
        [DataMember]

        public string VenueKey { set; get; }

        [DataMember]

        public string VenueLoginUsername { set; get; }

        [DataMember]

        public string VenueLoginPasswordPlain { set; get; }

        [DataMember]

        public string VenueName { set; get; }
}