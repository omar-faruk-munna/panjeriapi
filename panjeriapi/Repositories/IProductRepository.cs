using panjeriapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace panjeriapi.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductDto>> GetAllProduct();
    }
}
