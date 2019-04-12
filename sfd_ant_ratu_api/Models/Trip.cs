using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ant_ratu.Models
{
    public enum Cities { Kaunas, Vilnius }
    public class Trip
    {
        
        public Trip()
        {

        }

        public int Id { get; set; }

        public int DriverId { get; set; }

        public Cities Origin { get; set; }

        public Cities Destination { get; set; }

        public DateTime LeavingDate { get; set; }

    }
}
