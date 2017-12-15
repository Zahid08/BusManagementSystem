using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Entity
{
    public class Admin_entity
    {
        string username;
        string password;
        public string Username
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public string Pasword
        {
            set { this.password = value; }
            get { return this.password; }
        }
    }
}
