using Contact.Database;
using Contact.Entity;
using Contactto.Entity;
using System;
using System.Collections.Generic;
namespace Services
{
    public class User_service
    {
        
        User_Dataaccess useraccess = new User_Dataaccess();
        #region Add_method
        public int Add(User_Entity user)
        {
            return useraccess.Add(user);
        }
        #endregion

        #region Add_employee
        public int Addemployee(Employees emp)
        {
            return useraccess.Addemployee(emp);
        }
        #endregion

        #region Getlogin_method
        public List<User_Entity> Getlogin()
        {
            return useraccess.GetLogin();
        }
        #endregion

        #region Edited_seat method

        public int Edit_seat(Choch seat)
        {
            return useraccess.Edit_seat(seat);
        }
        #endregion

        #region add_passenger
        public int Add_passrnger(User_Entity passenger) {
            return useraccess.Add_passenger(passenger);
        }
        #endregion

        #region Delete_method
        public int Delete(string search)
        {
            return useraccess.Delete(search);
        }

        #endregion
    }

}
