using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car {CarId=1,ColorId=1, BrandId=1,ModelYear=2010,DailyPrice=50000,Description="4X4 Cross Arabası"},
            new Car {CarId=2,ColorId=1, BrandId=4,ModelYear=2003,DailyPrice=70000,Description="Aile Arabası"},
            new Car {CarId=3,ColorId=3, BrandId=4,ModelYear=2000,DailyPrice=60000,Description="Makam Arabası"},
            new Car {CarId=4,ColorId=4, BrandId=3,ModelYear=2006,DailyPrice=40000,Description="Spor Arabası"},
            new Car {CarId=5,ColorId=5, BrandId=2,ModelYear=1975,DailyPrice=80000,Description="Klasik Araba"}

            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            //Linq kullandım burada Foreach ile de aynı işi yapabilirdim ama uzun sürerdi,
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            Console.WriteLine("Seçilen Araba Silindi");
            
           
                        
            
        }

        public List<Car> GetAll()
        {
            
            
            Console.WriteLine("Bütün Araçlar Getirildi");
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
            
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
            
            
        }


        
    
    
    }   



}
