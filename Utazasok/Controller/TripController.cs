using Utazasok.Dao;
using Utazasok.Model;

namespace Utazasok.Controller
{
    public class TripController
    {
        private readonly ITrip_Dao dao;

        public TripController(ITrip_Dao dao) { this.dao = dao; }

        public bool AddTrip(Trip trip) { return this.dao.AddTrip(trip); }

        public bool DeleteTrip(int id) { return this.dao.DeleteTrip(id); }

        public bool ModifyTrip(Trip trip) { return this.dao.ModifyTrip(trip); }
        public IEnumerable<Trip> GetAllTrips() { return this.dao.GetAllTrips(); }
        public Trip GetTripById(int id) { return this.dao.GetTripById(id); }
    }
}
