using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactto.Entity
{
    public class Choch
    {
        string choch_No;
        string source;
        string destination;
        string tolat_Seat;
        string registation;
        string date_Time;
        string seat_no;
        string available;
        string amount;

        public string Choch_No
        {
            set
            {
                this.choch_No = value;
            }
            get
            {
                return this.choch_No;
            }

        }
        public string Amount
        {
            set
            {
                this.amount = value;
            }
            get
            {
                return this.amount;
            }

        }
        public string Available_Seat
        {
            set
            {
                this.available = value;
            }
            get
            {
                return this.available;
            }

        }
        public string Source
        {
            set
            {
                this.source = value;
            }
            get
            {
                return this.source;
            }
        }

        public string Destination
        {
            set
            {
                this.destination = value;
            }
            get
            {
                return this.destination;
            }
        }
        public string  Seat_no
        {
            set
            {
                this.seat_no = value;
            }
            get
            {
                return this.seat_no;
            }
        }
        public string Total_Seat
        {
            set
            {
                this.tolat_Seat = value;
            }
            get
            {
                return this.tolat_Seat;
            }
        }
        public string Registration
        {
            set
            {
                this.registation = value;
            }
            get
            {
                return this.registation;
            }
        }

        public string Date_Time
        {
            set
            {
                this.date_Time = value;
            }
            get
            {
                return this.date_Time;
            }
        }

    }
}
