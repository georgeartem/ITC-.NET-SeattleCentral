using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class LoginClass
    {
        private string pass;
        private string username;
        private int seed;
        private byte[] dbhash;
        private int key;
        private byte[] newHash;
    
    public LoginClass(string pass, string username)
    {   
        this.pass = pass;
        this.username = username;
   }
        private void GetUserInfo()
        { ShowTrackerEntities ste = new ShowTrackerEntities();
        var info = from i in ste.FanLogins
                   where i.FanLoginUserName.Equals(username)
                   select new { i.FanKey, i.FanLoginHashed, i.FanLoginRandom };
        foreach (var u in info)
        {
            seed = u.FanLoginRandom;
            dbhash = u.FanLoginHashed;
            key = u.FanKey;
        }
        }

        private void GetNewHash() 
        {
            PasswordHash h = new PasswordHash();
            newHash = h.HashIt(pass, seed.ToString());
        }
        private bool Comparehash()
        {
            bool goodLogin = false;

            if (dbhash != null)
            {
                if (newHash.SequenceEqual(dbhash))
            goodLogin = true;
            }

            return goodLogin;
        }
        public int ValidateLogin()
        {
            GetUserInfo();
            GetNewHash();
            bool result = Comparehash();

            if (!result)
                key = 0;

            return key;

        }

    }
