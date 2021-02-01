using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Araç Listeleme");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id+car.ModelYear+car.DailyPrice+car.Description+car.ColorId+car.BrandId);
            }

            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.WriteLine("Araç Ekleme");



        }
    }
}
