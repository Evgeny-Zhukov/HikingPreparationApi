using Core.Entities;

namespace Core.ValueObjects
{
    public class RoutePoint
    {
        public int RouteDay { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }
        
        public AltitudeChange AltitudeChange { get; private set; }

        public Altitude Altitude { get; private set; }

        public Distance Distance  { get; private set; }

        public RoutePoint(
            int routeDay, 
            string startPoint, 
            string endPoint, 
            AltitudeChange altitudeChange, 
            Altitude altitude, 
            Distance distance)
        {
            RouteDay = routeDay;
            StartPoint = startPoint;
            EndPoint = endPoint;
            AltitudeChange = altitudeChange;
            Altitude = altitude;
            Distance = distance;
        }
    }
}