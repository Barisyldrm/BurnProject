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

		public int ProductCount()
		{
			using var context = new BurnContext();
			return context.Products.Count();
		}

		public int ProductCountByCategoryNameDrink()
		{
			using var context = new BurnContext();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new BurnContext();
			return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
		}

		public string ProductNameByMaxPrice()
		{
			using var context = new BurnContext();
			return context.Products.Where(x => x.Price == context.Products.Max(y => y.Price)).Select(z => z.ProductName).FirstOrDefault();
		}

		public string ProductNameByMinPrice()
		{
			using var context = new BurnContext();
			return context.Products.Where(x => x.Price == context.Products.Min(y => y.Price)).Select(z => z.ProductName).FirstOrDefault();
		}

		public decimal ProductPriceAvg()
		{
			using var context = new BurnContext();
			return context.Products.Average(x => x.Price);
		}
	}
}
