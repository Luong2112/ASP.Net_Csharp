using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_ltwcoban
{
    public class Users
    {
        public string name { get; set; }
        public string email { get; set; }

        //public string dt { get; set; }
        public string password { get; set; }
        public string repassword { get; set; }

        public Users()
        {
        }

        public Users(string name, string email, string password, string repassword)
        {
            this.name = name;
            this.email = email;
            //this.dt = dt;
            this.password = password;
            this.repassword = repassword;
        }
    }
}