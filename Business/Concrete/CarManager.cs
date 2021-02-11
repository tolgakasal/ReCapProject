using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if (car.Description.Length<2 || car.Description.StartsWith(" "))
            {
                return new ErrorResult(Messages.CartNameInvaild);
            }
            else if (car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.CartNameInvaild);
            }
            else
            {
                _carDal.Add(car);

                return new SuccessResult(Messages.CarAdded);
              
            }
        }

     
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.CartNameInvaild);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
            
        }

        public IDataResult<List<Car>> GetCarsBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
