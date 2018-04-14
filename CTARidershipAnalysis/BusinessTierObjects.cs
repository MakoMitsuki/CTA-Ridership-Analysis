//
// BusinessTier objects:  these classes define the objects serving as data 
// transfer between UI and business tier.  These objects carry the data that
// is normally displayed in the presentation tier.  The classes defined here:
//
//    CTAStation
//    CTAStop
//
// NOTE: the presentation tier should not be creating instances of these objects,
// but instead calling the BusinessTier logic to obtain these objects.  You can 
// create instances of these objects if you want, but doing so has no impact on
// the underlying data store --- to change the data store, you have to call the
// BusinessTier logic.
//

using System;
using System.Collections.Generic;


namespace BusinessTier
{

  /// <summary>
  /// Info about one CTA station.
  /// </summary>
  public class CTAStation
  {
    public int ID {
            get;
            private set;
        }
    public string Name { get; private set; }
    public int TotalRidership { get; private set; }
    public int AvgRidership { get; private set; }
    public string PercentRidership { get; private set; }
    public int Weekday { get; private set; }
    public int Saturday { get; private set; }
    public int Sunday { get; private set; }
    
    // first constructor for station list
    public CTAStation(int stationID, string stationName)
    {
      ID = stationID;
      Name = stationName;
    }
    
    // second constructor for stationDetails
    public CTAStation(int stationID, int totalRidership, int avgRidership, string percentRidership, int weekday, int saturday, int sunday)
    {
            ID = stationID;
            TotalRidership = totalRidership;
            AvgRidership = avgRidership;
            PercentRidership = percentRidership;
            Weekday = weekday;
            Saturday = saturday;
            Sunday = sunday;
    }
  }
  
  /// <summary>
  /// Info about one CTA stop.
  /// </summary>
  public class CTAStop
  {
    public int ID {get; private set;}

    public string Name { get; private set; }

    public char Direction { get; private set; }

    public char ADA { get; private set; } // from bool to char for display

    public string Location { get; private set; }
    
    public List<string> Lines { get; private set; }

    public CTAStop(int stopID, string stopName)
    {
            ID = stopID;
            Name = stopName;
    }

        public CTAStop(int stopID, char direction, char ada, string location, List<string> lines)
    {
      ID = stopID;
      Direction = direction;
      ADA = ada;
      Location = location;
      Lines = lines;
    }
  }

}//namespace
