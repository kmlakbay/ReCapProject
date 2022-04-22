// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());
List<Car> cars = carManager.GetAll();

foreach (var car in cars)
{
    Console.WriteLine(car.Description);
}