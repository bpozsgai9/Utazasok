using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utazasok.Model;

namespace Utazasok.Dao
{
    public interface ITrip_Dao
    {
        bool AddTrip(Trip trip);

        bool DeleteTrip(int id);

        bool ModifyTrip(Trip trip);
        IEnumerable<Trip> GetAllTrips();
        Trip GetTripById(int id);
    }
}
