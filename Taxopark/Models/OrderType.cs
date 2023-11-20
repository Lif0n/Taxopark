namespace Taxopark.Models
{
    public class OrderType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}
