using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {Id=1,BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=250,Description="hyundai accent blue otomatik" },
                new Car {Id=2,BrandId=2,ColorId=2,ModelYear=2017,DailyPrice=350,Description="fiat egea dizel manuel" },
                new Car {Id=3,BrandId=1,ColorId=2,ModelYear=2018,DailyPrice=375,Description="hyundai elentra manuel benzinli" },
                new Car {Id=4,BrandId=3,ColorId=3,ModelYear=2015,DailyPrice=275,Description="ford focus otomatik" },
                new Car {Id=5,BrandId=2,ColorId=1,ModelYear=2012,DailyPrice=200,Description="fiat fiorino dizel manuel" },
                new Car {Id=6,BrandId=3,ColorId=1,ModelYear=2017,DailyPrice=350,Description="ford fiesta otomatik" },
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(x => x.Id == car.Id));
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetAllCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            if (updateCar != null)
            {
                updateCar.BrandId = car.BrandId;
                updateCar.ColorId = car.ColorId;
                updateCar.ModelYear = car.ModelYear;
                updateCar.DailyPrice = car.DailyPrice;
                updateCar.Description = car.Description;
            }

        }
    }
}
