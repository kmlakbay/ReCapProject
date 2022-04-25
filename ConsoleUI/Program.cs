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

static void Draw()
{
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
}
static void ListCars()
{
    CarManager carManager = new CarManager(new EfCarDal());
    List<Car> cars = carManager.GetAll();
    foreach (var car in cars)
    {
        Console.WriteLine(car.Description);
    }
}

static void ListColors()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());
    List<Color> colors = colorManager.GetAll();
    foreach (var color in colors)
    {
        Console.WriteLine(color.Name);
    }
}

static void ListBrands()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());
    List<Brand> brands = brandManager.GetAll();
    foreach (var brand in brands)
    {
        Console.WriteLine(brand.Name);
    }
}

static void ListCarDetails()
{
    CarManager carManager = new CarManager(new EfCarDal());
    List<CarDetailDto> cars = carManager.GetAllCarDetails();
    foreach (var car in cars)
    {
        Console.WriteLine("ID:{0} | DESCRIPTION:{1} | BRAND:{2} | COLOR:{3} | DAILYPRICE:{4}", car.Id, car.Description, car.BrandName, car.ColorName, car.DailyPrice);
    }
}