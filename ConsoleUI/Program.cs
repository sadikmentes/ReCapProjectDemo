using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
    public   static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " : " + car.DailyPrice);
            }
            Console.WriteLine();
            InMemoryCarDal carDal = new InMemoryCarDal();
            carDal.Add(new Entities.Concrete.Car { CarId = 7, Brand = "BMW", ColorId = 4, DailyPrice = 250, ModelYear = 2018, Description = "Ateş  Kırmızısı" });
            carDal.Update(new Entities.Concrete.Car { CarId = 2, Brand = "Mercedes", DailyPrice = 300, ModelYear = 2018, ColorId = 2, Description = "Beyaz uçak" });
            foreach (var updatedCar in carDal.GetAll())
            {
                Console.WriteLine(updatedCar.Description + " : " + updatedCar.DailyPrice);
            }

        }
    }
}
