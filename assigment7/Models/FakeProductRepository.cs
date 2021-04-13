using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assigment7.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Video game", Price = 60 },
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Nerf gun", Price = 120 }
        }.AsQueryable<Product>();
    }
}
