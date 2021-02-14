﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetAllByBrandName(string name)
        {
            return _brandDal.GetAll(p => p.BrandName == name);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _brandDal.GetCarDetails();
        }
    }
}
