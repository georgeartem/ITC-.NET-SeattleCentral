using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;



    public class PasswordHash
    {
        private string passwd;
        private string passkey;

        public Byte[] HashIt(string password, string passkey)
        {
            passwd = password;
            this.passkey = passkey;

            Byte[] originalBytes;
            Byte[] encodedBytes;
            SHA512 shaHash = SHA512.Create();

            string passToHash = passkey + passwd;

            originalBytes = ASCIIEncoding.Default.GetBytes(passToHash);
            encodedBytes = shaHash.ComputeHash(originalBytes);

            return encodedBytes;

        }
    }
