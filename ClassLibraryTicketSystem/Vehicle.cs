using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        public bool Brobizz { get; set; }
        private double price;

        private string _licensePlate;
        public string LicensePlate 
        {
            get { return _licensePlate; }
            set { 
                if (_licensePlate.Length > 7) 
                {
                    throw new ArgumentOutOfRangeException("License plate cannot be longer than 7 letters");
                } 
            }
        }
        public DateTime Date { get; set; }

        public virtual double Price() 
        {
           
            return price;
        }
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
        public Vehicle()
        {
            Brobizz = false;
            _licensePlate = "";
        }
        public virtual double Discount(double price)
        {
            if (Brobizz == true)
            {
                return price - (price * 0.05);
            }
            return price;
        }
    }
}
