using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltTicketLibrary
    {
        public List<Vehicle> ListOfVehicles;
        public enum DayOfWeek 
        { 
         Monday,
         Tuesday,
        Wednesday
        
        
        
        
        };

        public StoreBaeltTicketLibrary()
        {
            ListOfVehicles = new();
        }
        public void WeekendDiscount()
        {
            foreach (var item in ListOfVehicles)
            {
                if (item.VehicleType()=="car")  
                {
                    if (item.Date.Day.ToString()=="Sunday" || item.Date.Day.ToString() == "Saturday")
                    {
                        var newPrice = item.Price() - item.Price() * 0.2;
                        item.Discount(newPrice);
                       
                    }
                }
            }
        }

    }
}
