using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = CheckReturnDate(rental.CarId);
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetCarRentalDetail(r => r.CarId == carId && r.ReturnDate == null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentalAddedError);
            }
            return new SuccessResult(Messages.RentalChecked);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public DataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public DataResult<List<CarRentalDetailDTO>> GetRentalDetails()
        {
            Thread.Sleep(1000);
            return new SuccessDataResult<List<CarRentalDetailDTO>>(_rentalDal.GetCarRentalDetail());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        //UpdateReturnDate yapısı çok karışık
        public IResult UpdateReturnDate(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.RentalId == rental.RentalId);
            var updateRental = result.LastOrDefault();

            if (updateRental.ReturnDate != null)
            {
                return new ErrorResult(Messages.BrandAdded);
            }
            updateRental.ReturnDate = rental.ReturnDate;
            _rentalDal.Update(updateRental);
            return new SuccessResult(Messages.BrandDeleted);
        }
    }
}
