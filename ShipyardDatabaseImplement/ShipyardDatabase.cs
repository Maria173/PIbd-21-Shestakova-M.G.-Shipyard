﻿using ShipyardDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace ShipyardDatabaseImplement
{
    public class ShipyardDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-MQPN7LN\SQLEXPRESS;Initial Catalog=ShipyardDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Ship> Ships { set; get; }
        public virtual DbSet<ShipComponent> ShipComponents { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<WarehouseComponent> WarehouseComponents { get; set; }
    }
}
