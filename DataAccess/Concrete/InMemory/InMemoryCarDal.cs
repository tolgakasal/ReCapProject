using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1, BrandId=2,ColorId=1,DailyPrice=200,ModelYear="2020",Description="Dizel (Otomatik)"},
                new Car{Id=2, BrandId=2, ColorId=2,DailyPrice=200,ModelYear="2020",Description="Benzinli (Manuel)"},
                new Car{Id=3, BrandId=1, ColorId=1,DailyPrice=100,ModelYear="2019",Description="Benzinli" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedCar = _cars.Where(c=>c.Id==car.Id).SingleOrDefault();
            _cars.Remove(deletedCar);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _cars.Where(c=>c.Id== Id).SingleOrDefault();
        }

        public void Update(Car car)
        {
            Car updateCar = _cars.Where(c=>c.Id==car.Id).SingleOrDefault();
            updateCar.Id = 2;
            updateCar.BrandId = 1;
            updateCar.ColorId = 2;
            updateCar.DailyPrice = 250;
            updateCar.ModelYear = "2020";
            updateCar.Description = "Dizel(Otomatik)";

        }
    }
}
