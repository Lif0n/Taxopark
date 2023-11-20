namespace Taxopark.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phonenumber { get; set; }
        public List<Transport> Transports { get; set; }
        public Driver() 
        {
            Transports = new List<Transport>();
        }
    }
}
