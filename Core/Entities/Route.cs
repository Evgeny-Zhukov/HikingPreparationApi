using Core.ValueObjects;

namespace Core.Entities
{
    public class Route
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<RoutePoint> RoutePoints { get; set; }
    }
}
