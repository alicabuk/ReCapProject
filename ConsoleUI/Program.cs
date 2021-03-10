using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            //TEST
            //carManager.Add(new Car { });

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.BrandId +" " + brand.BrandName);
            //    if (brand.BrandId == 1003)
            //    {
            //        brand.BrandId = 3;
            //        brandManager.Update(brand);
            //    }
            //    Console.WriteLine(brand.BrandId + " " + brand.BrandName);

            //}
            var result = carManager.GetCarDetail();


            if(result.IsSuccess==true)
            {
                foreach(var car in result.Data)
                {
                    Console.WriteLine(car.ColorName + "Renkli " + car.CarName + " Markalı Aracın Fiyatı : " + car.DailyPrice + " TL");
                }
            }
            


        }
    }
}
