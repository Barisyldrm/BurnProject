using Burn.DataAccessLayer.Abstract;
using Burn.DataAccessLayer.Concrete;
using Burn.DataAccessLayer.Repositories;
using Burn.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(BurnContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCateories()
        {
            var context = new BurnContext();
            var values = context.Products.Include(x=> x.Category).ToList();
            return values;
        }
    }
}
