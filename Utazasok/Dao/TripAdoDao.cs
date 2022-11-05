using System.Data.SQLite;
using Utazasok.Model;

namespace Utazasok.Dao
{
    internal class TripAdoDao : ITrip_Dao
    {
        private SQLiteConnection connection;
        private SQLiteCommand actualCommand;
        private const string CONN_STRING = @"Data Source=../../../Db/utazasok.db";

        public TripAdoDao()
        {
            this.connection = new SQLiteConnection(CONN_STRING);
            this.actualCommand = connection.CreateCommand();
            this.connection.Open();
        }

        ~TripAdoDao() { this.connection.Close(); }

        public bool AddTrip(Trip trip)
        {
            this.actualCommand.CommandText =
                "insert into Items (Name, Category, Country, Description, Priority) " +
                "values (@name, @category, @country, @description, @prioroty);";

            this.actualCommand.Parameters.Add("name", System.Data.DbType.String).Value = trip.Name;
            this.actualCommand.Parameters.Add("category", System.Data.DbType.String).Value = trip.Category;
            this.actualCommand.Parameters.Add("country", System.Data.DbType.String).Value = trip.Country;
            this.actualCommand.Parameters.Add("description", System.Data.DbType.String).Value = trip.Description;
            this.actualCommand.Parameters.Add("prioroty", System.Data.DbType.String).Value = trip.Priority;

            try { this.actualCommand.ExecuteNonQuery(); }
            catch (Exception) { return false; }

            return true;
        }

        public bool DeleteTrip(int id)
        {
            this.actualCommand.CommandText = "delete from Items where ID=@id;";
            this.actualCommand.Parameters.Add("id", System.Data.DbType.String).Value = id;

            try { this.actualCommand.ExecuteNonQuery(); }
            catch (Exception) { return false; }

            return true;
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            List<Trip> localTripList = new List<Trip>();
            this.actualCommand.CommandText = "select * from Items";
            using var reader = actualCommand.ExecuteReader();
            while (reader.Read())
            {
                localTripList.Add(new Trip
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Category = reader.GetString(reader.GetOrdinal("Category")),
                    Country = reader.GetString(reader.GetOrdinal("Country")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                    Priority = reader.GetInt32(reader.GetOrdinal("Priority"))
                });
            }
            return localTripList;
        }

        public Trip GetTripById(int id)
        {
            this.actualCommand.CommandText = "select * from Items where ID = @id";
            this.actualCommand.Parameters.Add("id", System.Data.DbType.String).Value = id;
            using var reader = actualCommand.ExecuteReader();

            Trip actualTrip = new Trip
            {
                Id = id,
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Category = reader.GetString(reader.GetOrdinal("Category")),
                Country = reader.GetString(reader.GetOrdinal("Country")),
                Description = reader.GetString(reader.GetOrdinal("Description")),
                Priority = reader.GetInt32(reader.GetOrdinal("Priority"))
            };

            return actualTrip;
        }

        public bool ModifyTrip(Trip trip)
        {
            this.actualCommand.CommandText = "update Items set " +
                "Name=@name, Category=@category, Country=@country, Description=@description, Priority=@prioroty " +
                "where ID=@id;";

            this.actualCommand.Parameters.Add("name", System.Data.DbType.String).Value = trip.Name;
            this.actualCommand.Parameters.Add("category", System.Data.DbType.String).Value = trip.Category;
            this.actualCommand.Parameters.Add("country", System.Data.DbType.String).Value = trip.Country;
            this.actualCommand.Parameters.Add("description", System.Data.DbType.String).Value = trip.Description;
            this.actualCommand.Parameters.Add("prioroty", System.Data.DbType.String).Value = trip.Priority;
            this.actualCommand.Parameters.Add("id", System.Data.DbType.String).Value = trip.Id;

            try { this.actualCommand.ExecuteNonQuery(); }
            catch (Exception) { return false; }

            return true;
        }
    }
}
