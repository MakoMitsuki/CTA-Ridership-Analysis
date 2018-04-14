// BusinessTier:  business logic, acting as interface between UI and data store.

using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{
  // Business:
  public class Business
  {
    // Fields:
    private string _DBFile;
    private DataAccessTier.Data dataTier;

    /// <summary>
    /// Constructs a new instance of the business tier.  The format
    /// of the filename should be either |DataDirectory|\filename.mdf,
    /// or a complete Windows pathname.
    /// </summary>
    /// <param name="DatabaseFilename">Name of database file</param>
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;
      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }

    /// <summary>
    ///  Opens and closes a connection to the database, e.g. to
    ///  startup the server and make sure all is well.
    /// </summary>
    /// <returns>true if successful, false if not</returns>
    /// 
    public bool TestConnection()
    {
      return dataTier.OpenCloseConnection();
    }

    /// <summary>
    /// Returns all the CTA Stations, ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetStations(string filter)
    {
      List<CTAStation> stations = new List<CTAStation>();

      try
      {
                string append = "";
                if (filter != "")
                    append = String.Format(" WHERE Name LIKE '%{0}%'", filter);
                string sql = String.Format("SELECT * FROM Stations{0} ORDER BY Name ASC", append);
                DataSet ds = dataTier.ExecuteNonScalarQuery(sql);
                foreach(DataRow row in ds.Tables["TABLE"].Rows)
                {
                    stations.Add(new CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"])));
                }
      }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stations;
    }

    /// <summary>
    /// Returns the CTA Stops associated with a given station,
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStop objects</returns>
    public IReadOnlyList<CTAStop> GetStops(int stationID)
    {
      List<CTAStop> stops = new List<CTAStop>();

      try
      {
                string sql = String.Format("SELECT * FROM Stops WHERE StationID = '{0}' ORDER BY Name ASC", stationID);
                DataSet ds = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in ds.Tables["TABLE"].Rows)
                {
                    stops.Add(new CTAStop(Convert.ToInt16(row["StopID"]), Convert.ToString(row["Name"])));
                }
            }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStops: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stops;
    }

    /// <summary>
    /// Returns the top N CTA Stations by ridership, 
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetTopStations(int N)
    {
      if (N < 1)
        throw new ArgumentException("GetTopStations: N must be positive");

      List<CTAStation> stations = new List<CTAStation>();

      try
      {
                string sql = String.Format(@"SELECT TOP {0} Riderships.StationID AS StationID, Stations.Name AS Name, SUM(Riderships.DailyTotal) AS Total FROM Riderships
                    INNER JOIN Stations ON Riderships.StationID = Stations.StationID
                    GROUP BY Riderships.StationID, Stations.Name ORDER BY Total DESC", N);
                DataSet ds = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in ds.Tables["TABLE"].Rows)
                {
                    stations.Add(new CTAStation(Convert.ToInt32(row["StationID"]), Convert.ToString(row["Name"])));
                }
            }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stations;
    }

        /// <summary>
        /// Helper (or more like a cheater) function for GetStops that takes a station name
        /// and returns its corresponding stationID (since data retrieved from GUI is a string and
        /// we are not allowed to change the int parameter of GetStops) ( ;w;)/ iamsorry
        /// </summary>
        /// <returns>int stationID</returns>
        public int GetStationID(String stationName)
        {
            int stationID = 0;

            if (stationName == "")
                throw new ArgumentException("GetStationID: Invalid station name.");

            try
            {
                string sql = String.Format(@"SELECT StationID FROM Stations WHERE Name = '{0}'", stationName);
                object result = dataTier.ExecuteScalarQuery(sql);
                stationID = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetStationID: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return stationID;
        }

        // similar to GetStationID but for Stops
        public int GetStopID(String stopName)
        {
            int stopID = 0;
            if (stopName == "")
                throw new ArgumentException("GetStopID: Invalid stop name.");

            try
            {
                string sql = String.Format(@"SELECT StopID FROM Stops WHERE Name = '{0}'", stopName);
                object result = dataTier.ExecuteScalarQuery(sql);
                stopID = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetStopID: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return stopID;
        }

        // returns an total integer station count
        public int GetTotalStationCount()
        {
            int n = 0;
            string sql = "SELECT COUNT(*) FROM Stations";
            object result = dataTier.ExecuteScalarQuery(sql);
            n = Convert.ToInt32(result);
            return n;
        }

        // returns integer station count for filtered
        public int GetShowingStationCount(string filter)
        {
            int n = 0;
            string sql = String.Format("SELECT COUNT(*) FROM Stations WHERE Name LIKE '%{0}%'", filter);
            n = Convert.ToInt32(dataTier.ExecuteScalarQuery(sql));
            return n;
        }

        /********************** NICE CUMULATIVE GETX DETAILS FUNCTIONS \( ^O^ )/ *****************************************/
        // not sure if this is really needed when I have all the other functions below
        // but its a self-practice with using objects the BusinessTierObjects
        // plus its nice to have to call only one function in Presentation to grab all the data
        public CTAStation GetStationDetails(string stationName)
        {
            int stationID = GetStationID(stationName);
            CTAStation selectedStation = new CTAStation(stationID, GetTotalRidership(stationID), GetAverageRidership(stationID),
                GetPercentRidershipDisplay(stationID), GetRidershipByDay(stationID, 'W'), GetRidershipByDay(stationID, 'A'),
                GetRidershipByDay(stationID, 'U'));
            return selectedStation;
        }

        public CTAStop GetStopDetails(string stopName)
        {
            int stopID = GetStopID(stopName);
            CTAStop selectedStop = new CTAStop(stopID, GetDirection(stopID), GetHandicap(stopID),
                GetLocationDisplay(stopID), GetLines(stopID));
            return selectedStop;
        }

        /***************************************************************************************************************/

        /* COMPONENTS OF GETSTATIONDETAILS (is there a way to incorporate this into objects.cs?) */
        // returns total ridership
        public int GetTotalRidership(int stationID)
        {
            int totalRidership = 0;
            try
            {
                string sql = String.Format(@"SELECT SUM(CAST(DailyTotal AS float))
                    FROM Riderships WHERE StationID = '{0}' GROUP BY StationID", stationID);
                object result = dataTier.ExecuteScalarQuery(sql);
                totalRidership = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetTotalRidership: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return totalRidership;
        }

        // returns average ridership
        public int GetAverageRidership(int stationID)
        {
            int avgRidership = 0;
            int count = GetTotalStationCount();
            if (count != 0)
                avgRidership = GetTotalRidership(stationID) / count;
            return avgRidership;
        }

        // returns precent ridership with double decimal precision
        public string GetPercentRidershipDisplay(int stationID)
        {
            float percent = 0;
            double dailyTotal = 0;
            double actTotal = 0;

            try
            {
                string sql = String.Format(@"SELECT SUM(DailyTotal) FROM Riderships WHERE StationID = '{0}' GROUP BY StationID", stationID);
                object result = dataTier.ExecuteScalarQuery(sql);
                string sql2 = String.Format(@"SELECT SUM(CAST(DailyTotal as float)) FROM Riderships");
                object result2 = dataTier.ExecuteScalarQuery(sql2);
                dailyTotal = Convert.ToDouble(result);
                actTotal = Convert.ToDouble(result2);
                if (actTotal != 0)
                    percent = (float)(dailyTotal / actTotal) * (float)100;
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetPerecntRidershipDisplay: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return String.Format("{0:0.##}%", percent);
        }

        // returns ridership on a certain timeframe: W for weekday, A for Saturday and U for sunday/holiday
        public int GetRidershipByDay(int stationID, char day)
        {
            int daily = 0;

            try
            {
                string sql = String.Format("SELECT SUM(DailyTotal) FROM Riderships WHERE TypeOfDay = '{0}' AND StationID = '{1}'", day, stationID);
                object result = dataTier.ExecuteScalarQuery(sql);
                daily = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetDailyRidership: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return daily;
        }

        /* COMPONENTS OF GETSTOPDETAILS (is there a way to incorporate this into objects.cs?) */
        // returns formatted location
        public string GetLocationDisplay(int stopID)
        {
            string location = "";
            try
            {
                string sql = String.Format("SELECT CONCAT('(', Latitude, ', ',  Longitude, ')') AS Location FROM Stops WHERE StopID = {0}", stopID);
                object result = dataTier.ExecuteScalarQuery(sql);
                location = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetLocationDisplay: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return location;
        }

        public char GetHandicap(int stopID)
        {
            char handicap = '╳';
            try
            {
                String sql = String.Format("SELECT ADA FROM Stops WHERE StopID = {0}", stopID);
                object result = dataTier.ExecuteScalarQuery(sql);
                if (Convert.ToInt16(result) == 1)
                    handicap = '✓';
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetHandicap: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return handicap;
        }

        public char GetDirection(int stopID)
        {
            char d = 'N';
            try
            {
                string sql = String.Format("SELECT Direction FROM Stops WHERE StopID = {0}", stopID);
                object result = dataTier.ExecuteScalarQuery(sql);
                d = Convert.ToChar(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetLocationDisplay: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return d;
        }

        public List<string> GetLines(int stopID)
        {
            List<string> lines = new List<string>();
            
            try
            {
                string sql = String.Format(@"SELECT Lines.Color AS Color FROM Lines
	                LEFT JOIN StopDetails ON Lines.LineID = StopDetails.LineID 
	                RIGHT JOIN Stops ON Stops.StopID = StopDetails.StopID
	                WHERE Stops.StopID = '{0}'", stopID);
                DataSet ds = dataTier.ExecuteNonScalarQuery(sql);
                foreach (DataRow row in ds.Tables["TABLE"].Rows)
                {
                    lines.Add(Convert.ToString(row["Color"]));
                }
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.GetLines: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }
            return lines;
        }

        // updates ADA from form 2
        public bool updateADA(string selectedStopName, int update)
        {
            bool isChange = false;
            int result = 0;
            if (update < 0)
                return isChange;

            try
            {
                string sql = String.Format("UPDATE Stops SET ADA = {0} WHERE Name = '{1}'", update, selectedStopName);
                result = dataTier.ExecuteActionQuery(sql);
                if (result == 1)
                    isChange = true;
            }
            catch (Exception ex)
            {
                string msg = string.Format("Error in Business.updateADA: '{0}'", ex.Message);
                throw new ApplicationException(msg);
            }

            return isChange;
        }

    }//class
}//namespace
