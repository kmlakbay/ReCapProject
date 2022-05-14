using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll() 
        {
            return Ok(_carService.GetAll());
        }

        [HttpGet("getcarsbybrandid")]
        public IActionResult GetCarsByBrandId(int brandId) 
        {
            return Ok(_carService.GetCarsByBrandId(brandId));
        }
        [HttpGet("getcarsbycolorid")]
        public IActionResult GetCarsByColorId(int colorId) 
        {
            return Ok(_carService.GetCarsByColorId(colorId));
        }

        [HttpPost("add")]
        public IActionResult Add(Car car) 
        {
            return Ok(_carService.Add(car));
        }

        [HttpGet("getallcardetails")]
        public IActionResult GetAllCarDetails()
        {
            return Ok(_carService.GetAllCarDetails());
        }
        
    }
}
