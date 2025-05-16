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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TAdd(Booking entity)
        {
            _bookingDal.Add(entity);    
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public List<Booking> TGetAll()
        {
           return _bookingDal.GetAll();
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }

        public void TUpdate(UpdateAboutDto updateAboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
