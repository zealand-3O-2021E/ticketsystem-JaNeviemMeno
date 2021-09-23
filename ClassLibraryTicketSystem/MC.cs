using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// A class MC which i suppose is for a motorcycle :D 
    /// </summary>
    public class MC : Vehicle
    {
        //public string Licenseplate { get; set; }
        //public DateTime Date { get; set; }

        /// <summary>
        /// Method which returns price which is 125
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Method which returns the type of Vehicle
        /// </summary>
        /// <returns>MC as string</returns>
        public override string VehicleType()
        {
            return "MC";
        }
        


    }
}
