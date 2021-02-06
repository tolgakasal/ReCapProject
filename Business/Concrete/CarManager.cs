using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.Description.Length<2 || car.Description.StartsWith(" "))
            {
                Console.WriteLine("Please Enter a name bigger than 2 characters and not whitespace");
            }
            else if (car.DailyPrice<=0)
            {
                Console.WriteLine("Please enter a Dailyprice bigger than 0");
            }
            else
            {
                _carDal.Add(car);
              
            }
        }

     
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
