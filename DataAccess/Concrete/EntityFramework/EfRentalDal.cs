using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public IDataResult<Rental> GetLastRentalForCar(int carId)
        {
            using (ReCapDBContext context=new ReCapDBContext())
            {
                var lastRental=context.Set<Rental>().Where(r => r.CarId == carId).OrderBy(o => o.RentDate).FirstOrDefault();
                return new SuccessDataResult<Rental>(lastRental);
            }
        }
    }
}
