using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;      
        
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal; 
        }
        
        
        
        public IResult Add(Customer customer)
        {
            if (customer.UserId !=0)
            {
                _customerDal.Add(customer);
                return new SuccessResult(Messages.CustomerAdded);
            }
            return new ErrorResult(Messages.CustomerNotAdded);
        }

        public IResult Delete(Customer customer)
        {
            if (customer.Id != 0)
            {
                _customerDal.Delete(customer);
                return new SuccessResult(Messages.CustomersDeleted);

            }
            return new ErrorResult(Messages.UserNotDeleted);
            
            
        }


        public DataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public DataResult<List<CustomerDetailDTO>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDTO>>(_customerDal.GetCustomerDetails());
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
