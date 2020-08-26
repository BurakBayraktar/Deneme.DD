﻿using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Monitör", Price = 2000.50m, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Klavye", Price = 150.50m, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Laptop", Price = 3000.50m, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Kitap", Price = 25.00m, CategoryId = _ids[1] }
            );
        }
    }
}
