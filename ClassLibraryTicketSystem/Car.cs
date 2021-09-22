using System;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This is our Car class
    /// </summary>
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Method which returns price which is 240
        /// </summary>
        /// <returns>240</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Method which returns the type of Vehicle
        /// </summary>
        /// <returns>Car as string</returns>
        public string VehicleType()
        {
            return "car";
        }



    }
}
