using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetByIdsAsync(List<ProductId> ids);

        Task<List<Product>> GetAllAsync();
    }
}