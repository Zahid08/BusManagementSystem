using Contact.Database;
using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Choach_service
    {
        #region Get_destnation method
        Choach_dataaccess useraccess = new Choach_dataaccess();

        public Choch GetBydestiantion(string destination)
        {
            return useraccess.GetBydestination(destination);
        }
        #endregion

        #region Add_Choach_Method
        public int Add_chaoach(Choch choach)
        {
            return useraccess.Add_Choach(choach);
        }
        #endregion

    }
}
