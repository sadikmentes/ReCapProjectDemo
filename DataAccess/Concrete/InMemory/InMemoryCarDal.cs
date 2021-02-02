using DataAccess.Abstract;
using System;
using Entities.Concrete;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            

            {
                _car = new List<Car>
                {
                    new Car { CarId = 1, DailyPrice = 150, ModelYear = 2004, Brand = "Hyundai", Description = "Günübirlik İdeal" },
                    new Car { CarId = 2, DailyPrice = 400, ModelYear = 2013, Brand = "BMW", Description = "0 km de BMW" },
                    new Car { CarId = 3, DailyPrice = 1500, ModelYear = 2019, Brand = "Fiat", Description = "Doktordan Haftalık Kiralık Doblo" },
                    new Car { CarId = 4, DailyPrice = 3000, ModelYear = 2012, Brand = "Lincoln", Description = "Temiz Limuzin" },
                    new Car { CarId = 5, DailyPrice = 200, ModelYear = 2014, Brand = "Audi", Description = "Günlük-Haftalık-Aylık- Audi" },
                    new Car { CarId = 6, DailyPrice = 90, ModelYear = 2000, Brand = "Tofaş", Description = "Eski ama KULLANIŞLI" },
                    new Car { CarId = 7, DailyPrice = 200, ModelYear = 2019, Brand = "Mercedes", Description = "Kiralık en iyi araba" }

                };
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == c.CarId);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById()
        {
            return _car.Where(c => c.CarId == c.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Brand = car.Brand;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
