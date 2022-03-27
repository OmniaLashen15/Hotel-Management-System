﻿// <auto-generated />
using System;
using EFDay15.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFDay15.Migrations
{
    [DbContext(typeof(FrontEnd_ReservationContext))]
    partial class FrontEnd_ReservationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFDay15.Entities.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Apt_Suite")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Arrival_Time")
                        .HasColumnType("date");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Breakfast")
                        .HasColumnType("int");

                    b.Property<string>("Card_CVC")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Card_Exp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Card_Number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Card_Type")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<bool>("Check_In")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cleaning")
                        .HasColumnType("bit");

                    b.Property<int>("Dinner")
                        .HasColumnType("int");

                    b.Property<string>("Email_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Food_Bill")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Leaving_Time")
                        .HasColumnType("date");

                    b.Property<int>("Lunch")
                        .HasColumnType("int");

                    b.Property<int>("Number_Guest")
                        .HasColumnType("int");

                    b.Property<string>("Payment_Type")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Room_Floor")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Room_Number")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("Room_Type")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<bool>("S_Surprise")
                        .HasColumnType("bit");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Supply_Status")
                        .HasColumnType("bit");

                    b.Property<double>("Total_Bill")
                        .HasColumnType("float");

                    b.Property<bool>("Towel")
                        .HasColumnType("bit");

                    b.Property<string>("Zip_Code")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
