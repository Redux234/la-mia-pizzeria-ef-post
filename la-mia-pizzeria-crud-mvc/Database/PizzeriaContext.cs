﻿using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_crud_mvc.Database
{
    
        public class PizzeriaContext : DbContext
        {
            public DbSet<Pizze> Pizza { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Database=Pizzeria;" +
                "Integrated Security=True;TrustServerCertificate=True");
            }
        }
    
}
