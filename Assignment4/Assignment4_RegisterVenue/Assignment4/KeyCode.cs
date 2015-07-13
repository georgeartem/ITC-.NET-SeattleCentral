using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class KeyCode
    {

        public int GetKeyCode()
        {
            Random r = new Random();
            int key = r.Next(1000000, 9999999);
            return key;
        }

    }
