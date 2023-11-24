using Microsoft.EntityFrameworkCore;

using Taxopark.Models;

namespace Taxopark
{
    public class MainContext : DbContext
    {
               private readonly string _connectionString = "Data Source=192.168.227.12; initial Catalog=TaxoparkBesSen;" +
        "User ID=user04;Password=04;TrustServerCertificate=True";
/*        private readonly string _connectionString = "Data Source=DESKTOP-29PRVP2; initial Catalog=Taxopark; " +
            "Integrated Security=True;TrustServerCertificate=True";*/
        public DbSet<Transport> Transports { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        //public MainContext(DbContextOptions<MainContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transport>()
                .HasOne(p => p.Driver)
                .WithMany(t => t.Transports)
                .HasForeignKey(p => p.DriverId)
                .HasPrincipalKey(t => t.Id);
            modelBuilder.Entity<Order>()
                .HasOne(p => p.Transport)
                .WithMany(t => t.Orders)
                .HasForeignKey(p => p.TransportId)
                .HasPrincipalKey(t => t.Id);
            modelBuilder.Entity<Order>()
                .HasOne(p => p.OrderType)
                .WithMany(t => t.Orders)
                .HasForeignKey(p => p.OrderTypeId)
                .HasPrincipalKey(t => t.Id);

            modelBuilder.Entity<OrderType>().HasData(
                new OrderType[]
                {
                    new OrderType {Id = 1, Name = "Базовый"},
                    new OrderType {Id = 2,  Name = "Комфорт"},
                    new OrderType {Id = 3,  Name = "Экспресс"},
                    new OrderType {Id = 4,  Name = "С детьми"},
                });
            modelBuilder.Entity<Driver>().HasData(
                new Driver[]
                {
                   new Driver{Id = 1,  Name = "Поджог", Surname = "Сараев", Phonenumber = "88005553535"},
                   new Driver{Id = 2,  Name = "Рулон", Surname = "Обоев", Phonenumber = "+7903412343"},
                });
            modelBuilder.Entity<Transport>().HasData(
                new Transport[] 
                {
                    new Transport {Id = 1, Mark = "2106", Color = "черний", IsSelling = true, Platenumber = "а228уе779", DriverId = 1},
                    new Transport {Id = 2, Mark = "Mondeo", Color = "Серебрянный", IsSelling = false, Platenumber = "в666ор779", DriverId = 2},
                    new Transport {Id = 3, Mark = "Solaris", Color = "Белый", IsSelling = false, Platenumber = "к234пе30", DriverId = 1},
                });
            modelBuilder.Entity<Order>().HasData(
                new Order[]
                {
                    new Order{Id = 1, ClientName = "Иванов Иван Иванович", ClientPhonenumber = "+78234921342", OrderStatus = Status.Delivered, OrderTypeId = 3, From="ул. Пушкина", To="дом Колотушкина", Price = 450, TransportId = 3},
                    new Order{Id = 2, ClientName = "Петров Петр Петрович", ClientPhonenumber = "+78249278344", OrderStatus = Status.Canceled, OrderTypeId = 2, From="ул. Пушкина", To="дом Колотушкина", Price = 600, TransportId = 2},
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
