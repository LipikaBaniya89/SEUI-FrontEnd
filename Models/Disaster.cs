namespace DisasterReliefFrontEnd.Models
{
    public class Disaster
    {
        public string Id { get; set; }          // <-- string, not int
        public string Name { get; set; }
        public bool IsEmergency { get; set; }
        public double LocationRadius { get; set; }
        public double[] Coordinates { get; set; }  // for latitude/longitude
        public string Link { get; set; }
    }
}
