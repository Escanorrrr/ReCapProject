using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cr in context.Cars
                             join mdl in context.Models on cr.CarId equals mdl.Id
                             join brn in context.Brands on mdl.BrandId equals brn.BrandId
                             join clr in context.Colors on mdl.ColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 CarId = cr.CarId,
                                 BrandName = brn.BrandName,
                                 BrandId = mdl.BrandId,
                                 ModelName = mdl.ModelName,
                                 ColorName = clr.ColorName,
                                 ColorId = mdl.ColorId,
                                 ModelYear = mdl.ModelYear,
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cr in context.Cars
                             join mdl in context.Models on cr.CarId equals mdl.Id
                             join brn in context.Brands on mdl.BrandId equals brn.BrandId
                             join clr in context.Colors on mdl.ColorId equals clr.ColorId
                             where mdl.BrandId == brandId
                             select new CarDetailDto
                             {
                                 CarId = cr.CarId,
                                 BrandId = mdl.BrandId,
                                 ColorId = mdl.ColorId,
                                 BrandName = brn.BrandName,
                                 ModelName = mdl.ModelName,
                                 ColorName = clr.ColorName,
                                 ModelYear = mdl.ModelYear,
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int colorId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cr in context.Cars
                             join mdl in context.Models on cr.CarId equals mdl.Id
                             join brn in context.Brands on mdl.BrandId equals brn.BrandId
                             join clr in context.Colors on mdl.ColorId equals clr.ColorId
                             where mdl.ColorId == colorId
                             select new CarDetailDto
                             {
                                 CarId = cr.CarId,
                                 BrandName = brn.BrandName,
                                 BrandId = mdl.BrandId,
                                 ColorId = mdl.ColorId,
                                 ModelName = mdl.ModelName,
                                 ColorName = clr.ColorName,
                                 ModelYear = mdl.ModelYear,
                             };
                return result.ToList();
            }
        }
    }
}