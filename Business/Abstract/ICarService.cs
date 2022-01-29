using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        DataResult<List<Car>> GetAll();
        DataResult<List<CarDetailDto>> GetCarDetails();
        DataResult<List<CarDetailDto>> GetCarDetailsBrandId(int brandId);
        DataResult<List<CarDetailDto>> GetCarDetailsColorId(int colorId);





    }
}
