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
    public class EfCarDal : EfEntityRepositoryBase<Car, MyCarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyCarsContext context = new MyCarsContext()) 
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 ColorId = c.ColorId,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Descriptions = c.Descriptions,
                                 BrandName = b.BrandName,
                                 BrandId = b.BrandId
                             };

                return result.ToList();
            }
        }
    }
}
