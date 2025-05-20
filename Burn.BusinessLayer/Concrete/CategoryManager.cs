using Burn.BusinessLayer.Abstract;
using Burn.DataAccessLayer.Abstract;
using Burn.DtoLayer.AboutDto;
using Burn.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

		public int TActiveCategoryCount()
		{
			return _categoryDal.ActiveCategoryCount();
		}

		public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

		public int TCategoryCount()
		{
			return _categoryDal.CategoryCount();
		}

		public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

		public int TPassiveCategoryCount()
		{
			return _categoryDal.PassiveCategoryCount();
		}

		public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public void TUpdate(UpdateAboutDto updateAboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
