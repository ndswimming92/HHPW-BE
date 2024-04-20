﻿// <auto-generated />
using System;
using HHPW_BE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW_BE.Migrations
{
    [DbContext(typeof(HHPWDbContext))]
    partial class HHPWDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HHPW_BE.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Four Cheese",
                            Price = 10.99m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Margarita",
                            Price = 9.49m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chicken Alfredo",
                            Price = 11.99m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Veggie Delight",
                            Price = 12.49m
                        });
                });

            modelBuilder.Entity("HHPW_BE.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrderType")
                        .HasColumnType("text");

                    b.Property<string>("PaymentType")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("Tip")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 4, 17, 20, 41, 47, 396, DateTimeKind.Local).AddTicks(2730),
                            Email = "alice@example.com",
                            Name = "Alice Brown",
                            OrderType = "Dine-in",
                            PaymentType = "Debit Card",
                            Phone = "111-222-3333",
                            Status = true,
                            Tip = 3m,
                            Total = 12m,
                            UserId = 0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2024, 4, 14, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(233),
                            Email = "bob@example.com",
                            Name = "Bob Green",
                            OrderType = "Pickup",
                            PaymentType = "Cash",
                            Phone = "444-555-6666",
                            Status = false,
                            Tip = 12m,
                            Total = 5m,
                            UserId = 0
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2024, 4, 4, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(254),
                            Email = "charlie@example.com",
                            Name = "Charlie White",
                            OrderType = "Delivery",
                            PaymentType = "Online",
                            Phone = "777-888-9999",
                            Status = false,
                            Tip = 1.2m,
                            Total = 8m,
                            UserId = 0
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2024, 4, 13, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(259),
                            Email = "david@example.com",
                            Name = "David Black",
                            OrderType = "Dine-in",
                            PaymentType = "Credit Card",
                            Phone = "123-456-7890",
                            Status = true,
                            Tip = 4.4m,
                            Total = 9m,
                            UserId = 0
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2024, 4, 9, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(262),
                            Email = "eva@example.com",
                            Name = "Eva Red",
                            OrderType = "Pickup",
                            PaymentType = "Cash",
                            Phone = "987-654-3210",
                            Status = false,
                            Tip = 12m,
                            Total = 7m,
                            UserId = 0
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2024, 4, 10, 20, 41, 47, 398, DateTimeKind.Local).AddTicks(267),
                            Email = "frank@example.com",
                            Name = "Frank Yellow",
                            OrderType = "Delivery",
                            PaymentType = "Online",
                            Phone = "456-789-0123",
                            Status = false,
                            Tip = 5.2m,
                            Total = 36m,
                            UserId = 0
                        });
                });

            modelBuilder.Entity("HHPW_BE.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int?>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("HHPW_BE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Cashier")
                        .HasColumnType("boolean");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cashier = true,
                            Uid = "J4tmBKI4tGYLAcxcswvolIKzeFv2"
                        },
                        new
                        {
                            Id = 2,
                            Cashier = false,
                            Uid = "J4tmBKI4tGYLAcxc4wvolIKzeFv4"
                        });
                });

            modelBuilder.Entity("HHPW_BE.Models.OrderItem", b =>
                {
                    b.HasOne("HHPW_BE.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("HHPW_BE.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.Navigation("Item");

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
