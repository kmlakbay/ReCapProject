using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;
        public CarManager(ICarDal carDal)
        {
            _iCarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<2)
            {
                throw new Exception("açıklama 2 karakterden uzun olmalıdır.");
            }
            if (car.DailyPrice<=0)
            {
                throw new Exception("günlük fiyat 0 dan büyük olmalıdır.");
            }
            _iCarDal.Add(car);
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<CarDetailDto> GetAllCarDetails()
        {
            return _iCarDal.GetAllCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _iCarDal.GetAll(x => x.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _iCarDal.GetAll(x => x.ColorId == colorId);
        }
    }
}
