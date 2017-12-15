using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactto.Entity
{
    public class Employees
    {
        int id;
        string name;
        string phone;
        string salary;
        string email;
     

        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }


        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        public string Phone
        {
            set
            {
                this.phone = value;
            }
            get
            {
                return this.phone;
            }
        }
        public string Salary
        {
            set
            {
                this.salary = value;
            }
            get
            {
                return this.salary;
            }
        }
        public string Email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
    }
}
