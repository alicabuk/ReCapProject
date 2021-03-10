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
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=120,CarName="Renault",ModelYear=2008},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=200,CarName="Mercedes",ModelYear=2009},
                new Car{CarId=3,BrandId=3,ColorId=3,DailyPrice=170,CarName="Wolksvagen",ModelYear=2012},
                new Car{CarId=4,BrandId=4,ColorId=2,DailyPrice=150,CarName="Peugeot",ModelYear=2015},
                new Car{CarId=5,BrandId=1,ColorId=2,DailyPrice=80,CarName="Renault",ModelYear=2003},
                new Car{CarId=6,BrandId=1,ColorId=4,DailyPrice=130,CarName="Renault",ModelYear=2010},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;    
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarName = car.CarName;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
