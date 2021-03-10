using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext rentACarContext = new RentACarContext() )
            {
                var result = from c in rentACarContext.Cars
                             join b in rentACarContext.Brands
                             on c.BrandId equals b.BrandId
                             join d in rentACarContext.Colors
                             on c.ColorId equals d.ColorId
                             select new CarDetailDto {
                                 CarName=c.CarName,BrandName=b.BrandName,
                                 ColorName=d.ColorName,DailyPrice=c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
