using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        public virtual double Price() 
        {
            return 240;
        }
        public virtual string VehicleType()
        {
            return "Vehicle";
        }


    }
}
