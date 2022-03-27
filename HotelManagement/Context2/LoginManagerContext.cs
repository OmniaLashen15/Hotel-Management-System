﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using HotelManagement.Entities2;

namespace HotelManagement.Context2
{
    public partial class LoginManagerContext : DbContext
    {
        public LoginManagerContext()
        {
        }

        public LoginManagerContext(DbContextOptions<LoginManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Frontend> Frontends { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LOGIN_MANAGER;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Frontend>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK_Table");
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
               // entity.HasKey(e => e.UserName)
                    //.HasName("PK__kitchen__7628B51D2FDAF8B5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}