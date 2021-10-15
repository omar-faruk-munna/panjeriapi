using panjeriapi.Models;
using panjeriapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace panjeriapi.Services
{
    public class ProductRepository : IProductRepository
    {
        List<ProductDto> products = new List<ProductDto>()
        {
            new ProductDto { ProductId = 1, Amount = "300", Category = "1", Image = "", Price = "100", ProductName = "Product-1", Quantity = "3", WritterName = "Abdul Hakim" },
            new ProductDto { ProductId = 2, Amount = "500", Category = "2", Image = "", Price = "100", ProductName = "Product-12", Quantity = "3", WritterName = "Abu Ishaque" },
            new ProductDto { ProductId = 3, Amount = "3900", Category = "3", Image = "", Price = "100", ProductName = "Product-18", Quantity = "3", WritterName = "Abul Mansur Ahmed" },
            new ProductDto { ProductId = 4, Amount = "100", Category = "8", Image = "", Price = "100", ProductName = "Product-3", Quantity = "3", WritterName = "Abdullah Abu Sayeed" },
            new ProductDto { ProductId = 5, Amount = "1200", Category = "4", Image = "", Price = "100", ProductName = "Product-4", Quantity = "3", WritterName = "Farrukh Ahmad" },
            new ProductDto { ProductId = 6, Amount = "1100", Category = "9", Image = "", Price = "100", ProductName = "Product-5", Quantity = "3", WritterName = "Abdullah Abu Sayeed" },
            new ProductDto { ProductId = 7, Amount = "4400", Category = "12", Image = "", Price = "100", ProductName = "Product-6", Quantity = "3", WritterName = "Farrukh Ahmad" }
            //new ProductDto { ProductId = 8, Amount = "5300", Category = "4", Image = "", Price = "100", ProductName = "Product-7", Quantity = "3", WritterName = "Jamal" },
            //new ProductDto { ProductId = 9, Amount = "7000", Category = "4", Image = "", Price = "100", ProductName = "Product-9", Quantity = "3", WritterName = "Jamal" },
            //new ProductDto { ProductId = 10, Amount = "1900", Category = "7", Image = "", Price = "100", ProductName = "Product-22", Quantity = "3", WritterName = "Jamal" }
        };




        public async Task<List<ProductDto>> GetAllProduct()
        {
            return products;
        }
    }
}
