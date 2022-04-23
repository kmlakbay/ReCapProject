// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Car addedCar= new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2017, DailyPrice = 350, Description = "fiat egea dizel manuel" };
carManager.Add(addedCar);
List<Car> cars = carManager.GetAll();

foreach (var car in cars)
{
    Console.WriteLine(car.Description);
}