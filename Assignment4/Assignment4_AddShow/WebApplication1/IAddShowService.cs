using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAddShowService" in both code and config file together.
    [ServiceContract]
    public interface IAddShowService
    {
        [OperationContract]
        bool AddArtist(Artist a);

        [OperationContract]

        bool AddShow(Show s);

        [OperationContract]

        bool AddShowDetail(Show s, Venue v, ShowDetail sd, Artist a);
    }
}
