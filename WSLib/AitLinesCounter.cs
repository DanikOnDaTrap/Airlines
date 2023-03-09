using System;
using System.Data;
using System.Data.SqlClient;

namespace WSLib
{
    public static class AirLinesCounter
    {
        public static string[] IncomeCount(SqlConnection connection)
        {
            string querySQL = "Select Count(FlightID) AS [Count], SUM(TicketPrice) AS Income from Ticket Inner join Flight ON Flight.ID = Ticket.FlightID Inner join Route ON Route.ID = Flight.Route WHERE Canceled = 0";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(querySQL, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            string[] arr = { (table.Rows[0].Field<int>("Count")).ToString(), Decimal.ToDouble(table.Rows[0].Field<Decimal>("Income")).ToString() };

            return
                arr;
        }

        public static DataTable Expiration(SqlConnection connection)
        {
            string querySQL = "Select Id, Model, DATEADD(YEAR,Plane.Lifetime,Plane.Date) AS ExpirationDate From Plane";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(querySQL, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            return
                table;
        }

        public static DataTable Arrivals(SqlConnection connection)
        {
            string querySQL = "Select Flight.ID, DATEADD(HOUR,Route.Duration,Flight.DateTime) AS ArrivalTime from Flight Inner join Route ON Route.ID = Flight.Route";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(querySQL, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            return
                table;
        }
    }
}
