using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car{Id=1,BrandId=2,ColorId=5,ModelYear="2000",DailyPrice=45000,Description="yeni araba"},
                new Car{Id=2,BrandId=2,ColorId=5,ModelYear="2011",DailyPrice=50000,Description="eski kapı araba"},
                new Car{Id=3,BrandId=3,ColorId=7,ModelYear="2010",DailyPrice=90000,Description="eski araba"},
                new Car{Id=4,BrandId=5,ColorId=8,ModelYear="2015",DailyPrice=100000,Description="yeni kapı araba"},
                new Car{Id=5,BrandId=2,ColorId=3,ModelYear="2014",DailyPrice=150000,Description="yeni model araba"}

            };
        }
         
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;

        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
          
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
