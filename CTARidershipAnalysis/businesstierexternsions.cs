/* =========================== BUSINESS TIER EXTENSIONS ======================== */
/// <summary>
/// Helper (or more like a cheater) function for GetStops that takes a station name
/// and returns its corresponding stationID (since data retrieved from GUI is a string and
/// we are not allowed to change the int parameter of GetStops) ( ;w;)/ iamsorry
/// </summary>
/// <returns>int stationID</returns>
public int GetStationID (String stationName)
{
    int stationID = 0;

    if (stationName == "")
        throw new ArgumentException("GetStationID: Invalid station name.");

    try
    {
        string sql = String.Format(@"SELECT StationID FROM Stations WHERE Name = {0}", stationName);
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
public int GetStopID (String stopName)
 {
    int stopID = 0;
    if (stopName == "")
        throw new ArgumentException("GetStopID: Invalid stop name.");

    try
    {
        string sql = String.Format(@"SELECT StopID FROM Stops WHERE Name = {0}", stopName);
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

// returns an integer station count
public int GetStationCount()
{
    int n = 0;
    string sql = "SELECT COUNT(*) FROM Stations";
    object result = dataTier.ExecuteScalarQuery(sql);
    n = Convert.ToInt32(result);
    return n;
}

// returns total ridership
public double GetTotalRidership(int stationID)
{
   double totalRidership = 0;
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
public double GetAverageRidership(int stationID)
{
    double avgRidership = 0;
    int count = GetStationCount();
    if (count != 0)
            avgRidership = GetTotalRidership(stationID) / count;
    return avgRidership;
}

// returns precent ridership with double decimal precision
public string GetPercentRidershipDisplay(int stationID)
{
    double percent = 0.0;
    double dailyTotal = 0;
    double actTotal = 0;
    
    try
    {
        string sql = String.Format(@"SELECT SUM(DailyTotal) FROM Riderships WHERE StationID = '{0}' GROUP BY StationID", stationID);
        object result = dataTier.ExecuteScalarQuery(sql);
        dailyTotal = Convert.ToDouble(result);
        actTotal = GetTotalRidership(stationID);
        if (actTotal != 0)
            percent = (dailyTotal / GetTotalRidership(stationID)) * 100;
    }
    catch (Exception ex)
    {
        string msg = string.Format("Error in Business.GetPerecntRidershipDisplay: '{0}'", ex.Message);
        throw new ApplicationException(msg);
    }
    return percent.ToString("0.##") + "%";
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
    try {
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