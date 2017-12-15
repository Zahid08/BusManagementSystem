using Contact.Database;
using Contactto.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class Employee_service
    {
        Employee_dataaccess serviceemployee = new Employee_dataaccess();

        #region  Delete _employee_method

        public int Delete_emp(int id)
        {
            return serviceemployee.Delete_employee(id);
        }
        #endregion

        #region Update employee

        public int Update(Employees person)
        {
            return serviceemployee.Update_employee(person);
        }
        #endregion

        #region Getall method
        public List<Employees> GetAll()
        {
            return serviceemployee.GetAll_employee();
        }
        #endregion

        #region  GetId_method
        public Employees GetById(int id)
        {
            return serviceemployee.Get_employee_id(id);
        }
        #endregion

        #region Getname method
        public List<Employees> GetByName(string name)
        {
            List<Employees> personList = serviceemployee.GetAll_employee();
            List<Employees> filteredPersonList = new List<Employees>();
            foreach (Employees person in personList)
            {
                if (person.Name.ToLower().Contains(name.ToLower()))
                {
                    filteredPersonList.Add(person);
                }
            }
            return filteredPersonList;
        }
        #endregion

        #region Get_all_shorted_name
        public List<Employees> GetAllSortedByName()
        {
            List<Employees> personList = serviceemployee.GetAll_employee();
            personList.Sort(new PersonNameComparer());
            return personList;
        }
        #endregion

    }
    #region
    class PersonNameComparer : IComparer<Employees>
    {
        public int Compare(Employees x, Employees y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
    #endregion
}

