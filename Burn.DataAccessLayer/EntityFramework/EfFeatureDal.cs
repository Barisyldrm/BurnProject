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
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(BurnContext context) : base(context)
        {
        }
    }
}
