using System.ComponentModel.DataAnnotations.Schema;

namespace Taxopark.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientPhonenumber { get; set; }
        public Status OrderStatus { get; set; }
        public int OrderTypeId { get; set; }
        [ForeignKey("OrderTypeId")]
        public OrderType OrderType { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int TransportId { get; set; }
        [ForeignKey("TransportId")]
        public Transport Transport { get; set; }
        public double Price { get; set; }
    }
    public enum Status
    {
        Waiting,
        InTheWay,
        Delivered,
        Canceled
    }
}
