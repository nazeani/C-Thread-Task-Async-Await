using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public interface ICarService
    {
        Task Create(Car car);
        List<Car> GetAll();
        void ShowAllCars();
        List<Car> FindAllCars(Predicate<Car> predicate);

    }
}
