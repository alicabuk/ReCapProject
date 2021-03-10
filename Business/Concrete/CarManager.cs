using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length>2)
            {
                _carDal.Add(car);
                return new Result(true, "Araba eklendi.");
            }
            else
            {
                Console.WriteLine("Araba adı 2 karakterden uzun ve fiyatı 0 TL'den büyük olmalıdır.");
                return new Result(false);
            }
             
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, "Araba silindi.");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }
        public IDataResult<Car> Get(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "Araba güncellendi.");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail());
        }
    }
}
