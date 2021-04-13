using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assigment7.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
