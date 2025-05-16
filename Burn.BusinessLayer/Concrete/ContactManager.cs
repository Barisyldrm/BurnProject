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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public void TUpdate(UpdateAboutDto updateAboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
