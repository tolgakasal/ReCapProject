﻿using Core.DataAccess.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<Car,NorthwindContext>,ICarDal
    {
     
        public List<CarDetailDto> GetCarDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                




            }

            


        }


    }
}