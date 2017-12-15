using Contact.Database;
using Contact.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public class Admin_services
    {
         Admin_login_dataaccess acess = new Admin_login_dataaccess();
       
        #region Admin ligogint metho

        public List<Admin_entity> Getlogin_admin()
        {
            return acess.GetLogin();
        }

    }
    #endregion
}
