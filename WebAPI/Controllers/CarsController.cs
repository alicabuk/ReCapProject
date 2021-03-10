using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]

        public List<Car> Get()
        {
            return new List<Car>
            {
                new Car{CarId=1,ColorId=1,BrandId=1,CarName="Mercedes",DailyPrice=120,ModelYear=2003},
                new Car{CarId=2,ColorId=1,BrandId=2,CarName="Fiat",DailyPrice=100,ModelYear=2005}
            };
        }
    }
}
