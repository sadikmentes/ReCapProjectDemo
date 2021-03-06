﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;


namespace DataAccess.Abstract
{
  public  interface ICarDal
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetAll();

        List<Car> GetById();
    }
}
