using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        // Product'a özel işlemler için...
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
