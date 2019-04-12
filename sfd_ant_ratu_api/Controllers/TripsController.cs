using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ant_ratu.Models;
using Microsoft.AspNetCore.Mvc;


namespace ant_ratu.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : Controller
    {
        static List<Trip> Trips = new List<Trip>() { new Trip() { Id = 525, DriverId = 515, LeavingDate = new DateTime(2019, 4, 4) }, new Trip() { Id = 1125, DriverId = 20, LeavingDate = new DateTime(2019, 4, 4)}, new Trip() { Id = 1, DriverId = 515 } };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Trip>> GetAll()
        {
            return Trips;
        }

        // GET api/trips/5
        [HttpGet("{id}")]
        public ActionResult<Trip> GetSingleTrip(int id)
        {
            return Trips.Where(trip => id == trip.Id).First();
        }


        // GET api/trips/yyyy-MM-dd
        [HttpGet("{date}")]
        public ActionResult<List<Trip>> GetTripsByDate([FromRoute] DateTime date)
        {
            return Trips.Where(trip => DateTime.Compare(trip.LeavingDate, date) == 0).ToList();
        }

        // POST api/trips/5
        [HttpPost]
        public ActionResult<Trip> PostNewTrip([FromBody] Trip value)
        {
            Trips.Add(value);

            return value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            Trips.RemoveAll(trip => trip.Id == id);
        }

        // PATCH api/trips/5
        [HttpPatch("{id}")]
        public ActionResult<Trip> PatchTrip([FromRoute] int id, [FromBody] Trip updatedTrip)
        {
            int index = Trips.FindIndex(trip => id == trip.Id);
            Trips[index] = updatedTrip;
            return updatedTrip;
        }
    }
}