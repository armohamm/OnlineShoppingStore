using OnlineShopingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopingStore.Domain.Entities;

namespace OnlineShopingStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDBContext context = new EFDBContext();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }
    }
}
