using Burn.DataAccessLayer.Abstract;
using Burn.DataAccessLayer.Concrete;
using Burn.DataAccessLayer.Repositories;
using Burn.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(BurnContext context) : base(context)
        {
        }

		public int ActiveCategoryCount()
		{
			using var context = new BurnContext();
			return context.Categories.Where(x => x.Status == true).Count();
		}

		public int CategoryCount()
		{
			using var context = new BurnContext();
			return context.Categories.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context = new BurnContext();
			return context.Categories.Where(x => x.Status == false).Count();
		}
	}
}
