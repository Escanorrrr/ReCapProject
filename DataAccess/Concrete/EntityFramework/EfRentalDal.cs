using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        

        public List<CarRentalDetailDTO> GetCarRentalDetail(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rnt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cr in context.Cars on rnt.CarId equals cr.CarId
                             join mdl in context.Models on cr.CarId equals mdl.Id
                             join col in context.Colors on mdl.ColorId equals col.ColorId
                             join brd in context.Brands on mdl.BrandId equals brd.BrandId
                             join cus in context.Customers on rnt.CustomerId equals cus.Id
                             join usr in context.Users on cus.UserId equals usr.UserId
                             select new CarRentalDetailDTO
                             {
                                 RentalId = rnt.RentalId,
                                 CustomerName = usr.FirstName,
                                 CustomerLastName = usr.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 ModelName = mdl.ModelName,
                                 BrandName = brd.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 RentDate = rnt.RentDate,
                                 ReturnDate = rnt.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
