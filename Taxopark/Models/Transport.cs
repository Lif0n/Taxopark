namespace Taxopark.Models
{
    public class Transport
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Platenumber { get; set; }
        public string Color { get; set; }
        public bool IsSelling { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public List<Order> Orders { get; set; }
    }
}
