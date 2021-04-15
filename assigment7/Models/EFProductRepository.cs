using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assigment7.Data;

namespace assigment7.Models
{
    public class EFProductRepository : IProductRepository 
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
