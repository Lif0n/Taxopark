﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Taxopark;

#nullable disable

namespace Taxopark.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20231115134304_Fourth")]
    partial class Fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Taxopark.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Поджог",
                            Phonenumber = "88005553535",
                            Surname = "Сараев"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Рулон",
                            Phonenumber = "+7903412343",
                            Surname = "Обоев"
                        });
                });

            modelBuilder.Entity("Taxopark.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientPhonenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderTypeId");

                    b.HasIndex("TransportId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientName = "Иванов Иван Иванович",
                            ClientPhonenumber = "+78234921342",
                            From = "ул. Пушкина",
                            OrderStatus = 2,
                            OrderTypeId = 3,
                            Price = 450.0,
                            To = "дом Колотушкина",
                            TransportId = 3
                        },
                        new
                        {
                            Id = 2,
                            ClientName = "Петров Петр Петрович",
                            ClientPhonenumber = "+78249278344",
                            From = "ул. Пушкина",
                            OrderStatus = 3,
                            OrderTypeId = 2,
                            Price = 600.0,
                            To = "дом Колотушкина",
                            TransportId = 2
                        });
                });

            modelBuilder.Entity("Taxopark.Models.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Базовый"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Комфорт"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Экспресс"
                        },
                        new
                        {
                            Id = 4,
                            Name = "С детьми"
                        });
                });

            modelBuilder.Entity("Taxopark.Models.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<bool>("IsSelling")
                        .HasColumnType("bit");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platenumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.ToTable("Transports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "черний",
                            DriverId = 1,
                            IsSelling = true,
                            Mark = "2106",
                            Platenumber = "а228уе779"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Серебрянный",
                            DriverId = 2,
                            IsSelling = false,
                            Mark = "Mondeo",
                            Platenumber = "в666ор779"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Белый",
                            DriverId = 1,
                            IsSelling = false,
                            Mark = "Solaris",
                            Platenumber = "к234пе30"
                        });
                });

            modelBuilder.Entity("Taxopark.Models.Order", b =>
                {
                    b.HasOne("Taxopark.Models.OrderType", "OrderType")
                        .WithMany()
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Taxopark.Models.Transport", "Transport")
                        .WithMany()
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderType");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("Taxopark.Models.Transport", b =>
                {
                    b.HasOne("Taxopark.Models.Driver", "Driver")
                        .WithMany("Transports")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Taxopark.Models.Driver", b =>
                {
                    b.Navigation("Transports");
                });
#pragma warning restore 612, 618
        }
    }
}
