using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class CarImagesController : Controller
    {
        ICarImageService _carImageService;


        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetByImageId(carId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    
        public IActionResult GetById(int imageId)
        {
            var result = _carImageService.GetByCarId(imageId);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        public IActionResult Update([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Update(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.Add(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    };          
}
