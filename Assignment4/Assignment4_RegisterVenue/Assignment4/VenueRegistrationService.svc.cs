using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


    public class VenueRegistrationService : IVenueRegistrationService
    {
     

        public bool RegisterVenue(VenueLite v)
        {
            bool result = true;
            try
            {
                PasswordHash ph = new PasswordHash();
                KeyCode kc = new KeyCode();
                int code = kc.GetKeyCode();
                byte[] hashed = ph.HashIt(v.VenueLoginPasswordPlain, code.ToString());

                Venue ven = new Venue();

                ven.VenueName = v.VenueName;
                ven.VenueKey = v.VenueKey;
                ven.VenueLoginUserName = v.VenueLoginUsername;
                ven.VenueLoginPasswordPlain = v.VenueLoginPasswordPlain;
       

            }
            catch {
                result = false;
            }
            return result;
        }

        public int VenueLogin(string VenueLoginUserName, string VenueLoginPasswordPlain)
        {
            int id = 0;

            LoginClass lc = new LoginClass(VenueLoginPasswordPlain, VenueLoginUserName);
            id = lc.ValidateLogin();

            return id;
        }
    }

