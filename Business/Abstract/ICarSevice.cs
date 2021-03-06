﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       IResult Add(Car car);
       IResult Delete(Car car);
       IResult Update(Car car);
       IDataResult<List<Car>> GetAll();
       IDataResult<List<Car>> GetCarsBrandId(int id);
       IDataResult<List<Car>> GetCarsColorId(int id);

    }
}
