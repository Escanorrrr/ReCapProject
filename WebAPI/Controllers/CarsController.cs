using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CarsController : Controller
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;    
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();

        }
        [HttpPost("Add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            
            if (result.Success)
            {
                return Ok(result);                
            }
            return BadRequest();
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("Update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("getbyBrandId")]
        public IActionResult GetCarsByBrandId(int id)
        {
            var result = _carService.GetCarDetailsBrandId(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        
        }
        [HttpGet("getByColorId")]
        public IActionResult GetCarsByColorId(int id)
        {
            var result = _carService.GetCarDetailsColorId(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }

}
