﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodShop.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0GNCTAC; database=FoodShopDB; integrated security=true");
        }

        public DbSet <Food> Foods { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet <Admin> Admins { get; set; }
    }
}
