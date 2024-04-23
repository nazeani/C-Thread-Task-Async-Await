using Core.DataAccesLayer;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concretes
{
    public class CarService : ICarService
    {
        public Task Create(Car car)
        {
            return Task.Run(async () =>
            {
                await AppDb.cars.Add(car);

            });
        }

        public List<Car> FindAllCars(Predicate<Car> predicate)
        {
           return AppDb.cars.FindAll(predicate);
        }

        public List<Car> GetAll()
        {
            return AppDb.cars;
        }

        public void ShowAllCars()
        {
            AppDb.cars.ForEach(car => Console.WriteLine(car));
        }
    }
}
