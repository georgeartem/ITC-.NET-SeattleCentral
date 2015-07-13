using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AddShowService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AddShowService.svc or AddShowService.svc.cs at the Solution Explorer and start debugging.
    public class AddShowService : IAddShowService
    {
        ShowTrackerEntities ste = new ShowTrackerEntities();
        public bool AddArtist(Artist a)
        {
            bool result = true;

            try{
                Artist ar = new Artist();
                ar.ArtistKey = a.ArtistKey;
                ar.ArtistName = a.ArtistName;
                ar.ArtistEmail = a.ArtistEmail;
                ar.ArtistWebPage = a.ArtistWebPage;
                ste.Artists.Add(ar);
                ste.SaveChanges();
            }
            catch { result = false; }

            return result;
        }

        public bool AddShowDetail(ShowDetail sd, Show s, Artist a, Venue v)
        {
            bool result = true;

            try {
                ShowDetail shw = new ShowDetail();
                shw.ShowDetailKey = sd.ShowDetailKey;
                shw.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
                shw.ShowKey = sd.ShowKey;
                Artist artist = ste.Artists.FirstOrDefault(x => x.ArtistKey == a.ArtistKey);
                shw.Artists.Add(artist);
                Venue venue = ste.Venues.FirstOrDefault(y => y.VenueKey == v.VenueKey);
                shw.Venues.Add(venue);
                Show show = ste.Shows.FirstOrDefault(z => z.ShowKey == s.ShowKey);
                shw.Shows.Add(show);

                ste.ShowDetails.Add(shw);
                ste.SaveChanges();

            }
            catch
            {
                result = false;
            }
            return result;
        }


        public bool AddShow(Show s)
        {
            bool result = true;

            try
            {
                Show sh = new Show();
                sh.ShowKey = s.ShowKey;
                sh.ShowName = s.ShowName;
                sh.VenueKey = s.VenueKey;
                sh.ShowDate = s.ShowDate;
                sh.ShowTime = s.ShowTime;
                sh.ShowTicketInfo = s.ShowTicketInfo;
                sh.Venue = s.Venue;
                ste.Shows.Add(sh);
                ste.SaveChanges();
            }

            catch {
                result = false;
            }
            return result;
        }
    }
}
