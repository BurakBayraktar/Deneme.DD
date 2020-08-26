using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IProductService:IService<Product>
    {
        // İş süreçleri service (business) katmanında kodlanır.
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}
