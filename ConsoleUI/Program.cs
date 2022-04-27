using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Concrete.Dtos;

ListCars();
Draw();

ListColors();
Draw();

ListBrands();
Draw();

ListCarDetails();
Draw();

CarRent();
Draw();

static void Draw()
{
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
}
static void ListCars()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetAll();
    if (result.Success)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine(car.Description);
        }
    }
}

static void ListColors()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    var result = colorManager.GetAll();
    if (result.Success)
    {
        foreach (var color in result.Data)
        {
            Console.WriteLine(color.Name);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

}

static void ListBrands()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    var result = brandManager.GetAll();
    if (result.Success)
    {
        foreach (var brand in result.Data)
        {
            Console.WriteLine(brand.Name);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void ListCarDetails()
{
    CarManager carManager = new CarManager(new EfCarDal());
    var result = carManager.GetAllCarDetails();
    if (result.Success)
    {
        foreach (var car in result.Data)
        {
            Console.WriteLine("ID:{0} | DESCRIPTION:{1} | BRAND:{2} | COLOR:{3} | DAILYPRICE:{4}", car.Id, car.Description, car.BrandName, car.ColorName, car.DailyPrice);
        }
    }
}

static void CarRent()
{
    RentalManager rentalManager = new RentalManager(new EfRentalDal());
    Rental rental = new Rental() { CarId = 1, CustomerId = 1, RentDate = DateTime.Now };
    var result = rentalManager.Add(rental);
    Console.WriteLine(result.Message);
}