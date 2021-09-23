using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// base class vehicle
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Brobizz for knowing, if there is discount or not (true means there is, false there is not)
        /// </summary>
        public bool Brobizz { get; set; }
        private double price;

        private string _licensePlate;

        /// <summary>
        /// licence plate which cannot be longer than 7 characters
        /// </summary>
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
        /// <summary>
        /// date and time when we cross the bridge
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// price for crossing the bridge
        /// </summary>
        /// <returns></returns>
        public virtual double Price() 
        {
           
            return price;
        }
        /// <summary>
        /// type of vehicle which is crossing the bridge
        /// </summary>
        /// <returns></returns>
        public virtual string VehicleType()
        {
            return "Vehicle";
        }
        /// <summary>
        /// simple constructor so that we can make brobizz as false and say that the license plate is not empty string
        /// </summary>
        public Vehicle()
        {
            Brobizz = false;
            _licensePlate = "";
        }
        /// <summary>
        /// counting the price if there is brobizz 
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
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
