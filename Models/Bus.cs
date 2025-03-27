namespace BusSchedule.Models
{
    public class Bus
    {
        public int Id { get; set; }
        public string Route { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string BusType { get; set; } // e.g., AC, Non-AC
    }
}
