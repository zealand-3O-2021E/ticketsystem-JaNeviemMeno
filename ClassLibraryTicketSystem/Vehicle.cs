using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        private string _licensePlate;
        public string LicensePlate 
        {
            get { return _licensePlate; }
            set { 
                if (LicensePlate.Length > 7) 
                {
                    throw new ArgumentOutOfRangeException("License plate cannot be longer than 7 letters");
                } 
            }
        }
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
