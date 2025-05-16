using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burn.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);
        void TDelete(T entity);
        List<T> TGetAll();
        T TGetByID(int id);
        void TUpdate(T entity);
        void TUpdate(Burn.DtoLayer.AboutDto.UpdateAboutDto updateAboutDto);
    }
}
