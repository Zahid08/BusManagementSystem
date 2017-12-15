using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Entity
{
   public class User_Entity : Choch
    {
        string name;
        string email;
        string username;
        string phone;
        string password;
        private int v;

        public User_Entity() {
        }

        public User_Entity(int v)
        {
            this.v = v;
        }

        public string Name
        { set { this.name = value; }
            get {  return this.name; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Username
        {
            set { this.username = value; }
            get { return this.username; }
        }
        public string Phone
        {
            set { this.phone = value; }
            get { return this.phone; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

    }
}
